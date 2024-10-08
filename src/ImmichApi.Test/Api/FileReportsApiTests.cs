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
    ///  Class for testing FileReportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FileReportsApiTests : IDisposable
    {
        private FileReportsApi instance;

        public FileReportsApiTests()
        {
            instance = new FileReportsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FileReportsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FileReportsApi
            //Assert.IsType<FileReportsApi>(instance);
        }

        /// <summary>
        /// Test FixAuditFiles
        /// </summary>
        [Fact]
        public void FixAuditFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FileReportFixDto fileReportFixDto = null;
            //instance.FixAuditFiles(fileReportFixDto);
        }

        /// <summary>
        /// Test GetAuditFiles
        /// </summary>
        [Fact]
        public void GetAuditFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAuditFiles();
            //Assert.IsType<FileReportDto>(response);
        }

        /// <summary>
        /// Test GetFileChecksums
        /// </summary>
        [Fact]
        public void GetFileChecksumsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FileChecksumDto fileChecksumDto = null;
            //var response = instance.GetFileChecksums(fileChecksumDto);
            //Assert.IsType<List<FileChecksumResponseDto>>(response);
        }
    }
}
