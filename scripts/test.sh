#!/bin/sh
set -e

BACKEND_URL="http://localhost:5000";

# Ensure we have API key
API_KEY="${MBED_CLOUD_SDK_API_KEY}"
if [ -z $API_KEY ]; then
  >&2 echo "API Key needs to be set using MBED_CLOUD_SDK_API_KEY env var";
  exit 1;
fi

dotnet run --project ./Tests/MbedCloudSDK.IntegrationTests/MbedCloudSDK.IntegrationTests.csproj --no-build --no-restore -c Release &

sleep 5

# Start the test runner
docker run --rm --net=host --name=testrunner_container -e "TEST_SERVER_URL=localhost:5000" -e "TEST_FIXTURES_DIR=/home/ubuntu/rpc_fixtures" -v /home/ubuntu/rpc_fixtures:/runner/test_fixtures -v /home/ubuntu/rpc_results:/runner/results ${TESTRUNNER_DOCKER_IMAGE}
RET_CODE=$?

curl -X POST http://localhost:5000/shutdown -d '{}' -H "Content-Type: application/json"

exit $RET_CODE