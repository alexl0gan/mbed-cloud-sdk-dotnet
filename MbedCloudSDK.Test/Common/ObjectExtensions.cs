using System.Collections.Generic;
using MbedCloudSDK.Certificates.Model;
using MbedCloudSDK.Common;
using MbedCloudSDK.DeviceDirectory.Model.Query;
using NUnit.Framework;

namespace MbedCloudSDK.Test.Common
{
    [TestFixture]
    public class ObjectExtensions
    {
        [Test]
        public void MapToObject()
        {
            var originalCertificate = new Certificate();
            originalCertificate.Description = "description of certificate";
            originalCertificate.Name = "Original Certificate";

            var updatedCertificate = new Certificate();
            updatedCertificate.Name = "Updated Certificate";

            var certificate = Utils.MapToUpdate(originalCertificate, updatedCertificate) as Certificate;

            Assert.AreEqual("Updated Certificate", certificate.Name);
        }

        [Test]
        public void MapToObjectWithNewFilter()
        {
            var originalQuery = new Query();
            originalQuery.Name = "Query";
            originalQuery.Filter = new MbedCloudSDK.Common.Filter.Filter();
            originalQuery.Filter.Add("orig", "true");

            var queryToUpdate = new Query();
            queryToUpdate.Filter = new MbedCloudSDK.Common.Filter.Filter();
            queryToUpdate.Filter.Add("new", "true");

            var query = Utils.MapToUpdate(originalQuery, queryToUpdate) as Query;
            Assert.IsTrue(query.Filter.Contains("new"));
            Assert.IsFalse(query.Filter.Contains("orig"));
        }

        [Test]
        public void MapToObjectWithBlankFilter()
        {
            var originalQuery = new Query();
            originalQuery.Name = "Query";
            originalQuery.Filter = new MbedCloudSDK.Common.Filter.Filter();
            originalQuery.Filter.Add("orig", "true");

            var queryToUpdate = new Query();
            queryToUpdate.Filter = new MbedCloudSDK.Common.Filter.Filter();
            queryToUpdate.Filter.IsBlank = true;

            var query = Utils.MapToUpdate(originalQuery, queryToUpdate) as Query;
            Assert.IsTrue(query.Filter.Contains("orig"));
        }

        [Test]
        public void IsValidJsonReturnsTrue()
        {
            var json = "{\"key\": {\"$eq\": \"value\"}, \"error\": {\"$ne\": \"found\"}, \"range\": {\"$lte\": \"10\", \"$gte\": \"2\"}}";
            var isValidJson = Utils.IsValidJson(json);
            Assert.IsTrue(isValidJson);
        }

        [Test]
        public void IsValidJsonArrayReturnsTrue()
        {
            var json = "[{\"key\": {\"$eq\": \"value\"}}, {\"error\": {\"$ne\": \"found\"}}, {\"range\": {\"$lte\": \"10\", \"$gte\": \"2\"}}]";
            var isValidJson = Utils.IsValidJson(json);
            Assert.IsTrue(isValidJson);
        }

        [Test]
        public void InvalidJsonReturnsFalse()
        {
            var json = "key=value&error__neq=found&range__lte=10&range__gte=2";
            var isValidJson = Utils.IsValidJson(json);
            Assert.IsFalse(isValidJson);
        }

        [Test]
        public void InvalidJsonThrowsJsonReaderException()
        {
            var json = "{key=value&error__neq=found&range__lte=10&range__gte=2}";
            var isValidJson = Utils.IsValidJson(json);
            Assert.IsFalse(isValidJson);
        }

        [Test]
        public void GetPropertiesOfAnObjectShouldReturnCorrectDictionary()
        {
            var obj = new { propertyOne = "one", propertyTwo = "two" };
            var dict = obj.GetProperties();
            var correctDict = new Dictionary<string, object>();
            correctDict.Add("propertyOne", "one");
            correctDict.Add("propertyTwo", "two");
            Assert.AreEqual(correctDict, dict);
        }
    }
}