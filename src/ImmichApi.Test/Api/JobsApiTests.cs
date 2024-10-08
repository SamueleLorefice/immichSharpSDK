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
    ///  Class for testing JobsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class JobsApiTests : IDisposable
    {
        private JobsApi instance;

        public JobsApiTests()
        {
            instance = new JobsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of JobsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' JobsApi
            //Assert.IsType<JobsApi>(instance);
        }

        /// <summary>
        /// Test GetAllJobsStatus
        /// </summary>
        [Fact]
        public void GetAllJobsStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllJobsStatus();
            //Assert.IsType<AllJobStatusResponseDto>(response);
        }

        /// <summary>
        /// Test SendJobCommand
        /// </summary>
        [Fact]
        public void SendJobCommandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JobName id = null;
            //JobCommandDto jobCommandDto = null;
            //var response = instance.SendJobCommand(id, jobCommandDto);
            //Assert.IsType<JobStatusDto>(response);
        }
    }
}
