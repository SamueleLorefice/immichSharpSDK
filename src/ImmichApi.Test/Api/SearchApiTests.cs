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
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SearchApiTests : IDisposable
    {
        private SearchApi instance;

        public SearchApiTests()
        {
            instance = new SearchApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SearchApi
            //Assert.IsType<SearchApi>(instance);
        }

        /// <summary>
        /// Test GetAssetsByCity
        /// </summary>
        [Fact]
        public void GetAssetsByCityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAssetsByCity();
            //Assert.IsType<List<AssetResponseDto>>(response);
        }

        /// <summary>
        /// Test GetExploreData
        /// </summary>
        [Fact]
        public void GetExploreDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetExploreData();
            //Assert.IsType<List<SearchExploreResponseDto>>(response);
        }

        /// <summary>
        /// Test GetSearchSuggestions
        /// </summary>
        [Fact]
        public void GetSearchSuggestionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SearchSuggestionType type = null;
            //string? country = null;
            //string? make = null;
            //string? model = null;
            //string? state = null;
            //var response = instance.GetSearchSuggestions(type, country, make, model, state);
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test SearchMetadata
        /// </summary>
        [Fact]
        public void SearchMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MetadataSearchDto metadataSearchDto = null;
            //var response = instance.SearchMetadata(metadataSearchDto);
            //Assert.IsType<SearchResponseDto>(response);
        }

        /// <summary>
        /// Test SearchPerson
        /// </summary>
        [Fact]
        public void SearchPersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //bool? withHidden = null;
            //var response = instance.SearchPerson(name, withHidden);
            //Assert.IsType<List<PersonResponseDto>>(response);
        }

        /// <summary>
        /// Test SearchPlaces
        /// </summary>
        [Fact]
        public void SearchPlacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.SearchPlaces(name);
            //Assert.IsType<List<PlacesResponseDto>>(response);
        }

        /// <summary>
        /// Test SearchSmart
        /// </summary>
        [Fact]
        public void SearchSmartTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SmartSearchDto smartSearchDto = null;
            //var response = instance.SearchSmart(smartSearchDto);
            //Assert.IsType<SearchResponseDto>(response);
        }
    }
}
