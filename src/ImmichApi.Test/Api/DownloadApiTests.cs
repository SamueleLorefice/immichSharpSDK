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
    ///  Class for testing DownloadApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DownloadApiTests : IDisposable
    {
        private DownloadApi instance;

        public DownloadApiTests()
        {
            instance = new DownloadApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DownloadApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DownloadApi
            //Assert.IsType<DownloadApi>(instance);
        }

        /// <summary>
        /// Test DownloadArchive
        /// </summary>
        [Fact]
        public void DownloadArchiveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AssetIdsDto assetIdsDto = null;
            //string? key = null;
            //var response = instance.DownloadArchive(assetIdsDto, key);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test GetDownloadInfo
        /// </summary>
        [Fact]
        public void GetDownloadInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DownloadInfoDto downloadInfoDto = null;
            //string? key = null;
            //var response = instance.GetDownloadInfo(downloadInfoDto, key);
            //Assert.IsType<DownloadResponseDto>(response);
        }
    }
}
