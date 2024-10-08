/*
 * Immich
 *
 * Immich API
 *
 * The version of the OpenAPI document: 1.110.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using ImmichApi.Client;
using ImmichApi.Api;
// uncomment below to import models
//using ImmichApi.Model;

namespace ImmichApi.Test.Api
{
    /// <summary>
    ///  Class for testing AuditApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuditApiTests : IDisposable
    {
        private AuditApi instance;

        public AuditApiTests()
        {
            instance = new AuditApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuditApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuditApi
            //Assert.IsType<AuditApi>(instance);
        }

        /// <summary>
        /// Test GetAuditDeletes
        /// </summary>
        [Fact]
        public void GetAuditDeletesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime after = null;
            //EntityType entityType = null;
            //Guid? userId = null;
            //var response = instance.GetAuditDeletes(after, entityType, userId);
            //Assert.IsType<AuditDeletesResponseDto>(response);
        }
    }
}
