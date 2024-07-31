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
    ///  Class for testing DeprecatedApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DeprecatedApiTests : IDisposable
    {
        private DeprecatedApi instance;

        public DeprecatedApiTests()
        {
            instance = new DeprecatedApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DeprecatedApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DeprecatedApi
            //Assert.IsType<DeprecatedApi>(instance);
        }

        /// <summary>
        /// Test GetAboutInfo
        /// </summary>
        [Fact]
        public void GetAboutInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAboutInfo();
            //Assert.IsType<ServerAboutResponseDto>(response);
        }

        /// <summary>
        /// Test GetServerConfig
        /// </summary>
        [Fact]
        public void GetServerConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetServerConfig();
            //Assert.IsType<ServerConfigDto>(response);
        }

        /// <summary>
        /// Test GetServerFeatures
        /// </summary>
        [Fact]
        public void GetServerFeaturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetServerFeatures();
            //Assert.IsType<ServerFeaturesDto>(response);
        }

        /// <summary>
        /// Test GetServerStatistics
        /// </summary>
        [Fact]
        public void GetServerStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetServerStatistics();
            //Assert.IsType<ServerStatsResponseDto>(response);
        }

        /// <summary>
        /// Test GetServerVersion
        /// </summary>
        [Fact]
        public void GetServerVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetServerVersion();
            //Assert.IsType<ServerVersionResponseDto>(response);
        }

        /// <summary>
        /// Test GetStorage
        /// </summary>
        [Fact]
        public void GetStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStorage();
            //Assert.IsType<ServerStorageResponseDto>(response);
        }

        /// <summary>
        /// Test GetSupportedMediaTypes
        /// </summary>
        [Fact]
        public void GetSupportedMediaTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSupportedMediaTypes();
            //Assert.IsType<ServerMediaTypesResponseDto>(response);
        }

        /// <summary>
        /// Test GetTheme
        /// </summary>
        [Fact]
        public void GetThemeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTheme();
            //Assert.IsType<ServerThemeDto>(response);
        }

        /// <summary>
        /// Test PingServer
        /// </summary>
        [Fact]
        public void PingServerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PingServer();
            //Assert.IsType<ServerPingResponse>(response);
        }
    }
}
