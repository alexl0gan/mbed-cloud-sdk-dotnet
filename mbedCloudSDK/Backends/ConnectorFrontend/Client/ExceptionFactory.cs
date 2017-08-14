/* 
 * Connect-Synchronizer REST API
 *
 * Connect-Synchronizer REST API simplyfies async requests for Service Portal, hiding the async behaviour and making those look like synchronous. 
 *
 * OpenAPI spec version: 3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using System;
using RestSharp;

namespace connector_frontend.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}