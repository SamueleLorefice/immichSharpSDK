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
    ///  Class for testing LibrariesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LibrariesApiTests : IDisposable
    {
        private LibrariesApi instance;

        public LibrariesApiTests()
        {
            instance = new LibrariesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LibrariesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LibrariesApi
            //Assert.IsType<LibrariesApi>(instance);
        }

        /// <summary>
        /// Test CreateLibrary
        /// </summary>
        [Fact]
        public void CreateLibraryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateLibraryDto createLibraryDto = null;
            //var response = instance.CreateLibrary(createLibraryDto);
            //Assert.IsType<LibraryResponseDto>(response);
        }

        /// <summary>
        /// Test DeleteLibrary
        /// </summary>
        [Fact]
        public void DeleteLibraryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteLibrary(id);
        }

        /// <summary>
        /// Test GetAllLibraries
        /// </summary>
        [Fact]
        public void GetAllLibrariesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllLibraries();
            //Assert.IsType<List<LibraryResponseDto>>(response);
        }

        /// <summary>
        /// Test GetLibrary
        /// </summary>
        [Fact]
        public void GetLibraryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetLibrary(id);
            //Assert.IsType<LibraryResponseDto>(response);
        }

        /// <summary>
        /// Test GetLibraryStatistics
        /// </summary>
        [Fact]
        public void GetLibraryStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetLibraryStatistics(id);
            //Assert.IsType<LibraryStatsResponseDto>(response);
        }

        /// <summary>
        /// Test RemoveOfflineFiles
        /// </summary>
        [Fact]
        public void RemoveOfflineFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.RemoveOfflineFiles(id);
        }

        /// <summary>
        /// Test ScanLibrary
        /// </summary>
        [Fact]
        public void ScanLibraryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //ScanLibraryDto scanLibraryDto = null;
            //instance.ScanLibrary(id, scanLibraryDto);
        }

        /// <summary>
        /// Test UpdateLibrary
        /// </summary>
        [Fact]
        public void UpdateLibraryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //UpdateLibraryDto updateLibraryDto = null;
            //var response = instance.UpdateLibrary(id, updateLibraryDto);
            //Assert.IsType<LibraryResponseDto>(response);
        }

        /// <summary>
        /// Test Validate
        /// </summary>
        [Fact]
        public void ValidateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //ValidateLibraryDto validateLibraryDto = null;
            //var response = instance.Validate(id, validateLibraryDto);
            //Assert.IsType<ValidateLibraryResponseDto>(response);
        }
    }
}
