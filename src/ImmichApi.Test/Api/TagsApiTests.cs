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
    ///  Class for testing TagsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TagsApiTests : IDisposable
    {
        private TagsApi instance;

        public TagsApiTests()
        {
            instance = new TagsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TagsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TagsApi
            //Assert.IsType<TagsApi>(instance);
        }

        /// <summary>
        /// Test CreateTag
        /// </summary>
        [Fact]
        public void CreateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTagDto createTagDto = null;
            //var response = instance.CreateTag(createTagDto);
            //Assert.IsType<TagResponseDto>(response);
        }

        /// <summary>
        /// Test DeleteTag
        /// </summary>
        [Fact]
        public void DeleteTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.DeleteTag(id);
        }

        /// <summary>
        /// Test GetAllTags
        /// </summary>
        [Fact]
        public void GetAllTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllTags();
            //Assert.IsType<List<TagResponseDto>>(response);
        }

        /// <summary>
        /// Test GetTagAssets
        /// </summary>
        [Fact]
        public void GetTagAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetTagAssets(id);
            //Assert.IsType<List<AssetResponseDto>>(response);
        }

        /// <summary>
        /// Test GetTagById
        /// </summary>
        [Fact]
        public void GetTagByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.GetTagById(id);
            //Assert.IsType<TagResponseDto>(response);
        }

        /// <summary>
        /// Test TagAssets
        /// </summary>
        [Fact]
        public void TagAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //AssetIdsDto assetIdsDto = null;
            //var response = instance.TagAssets(id, assetIdsDto);
            //Assert.IsType<List<AssetIdsResponseDto>>(response);
        }

        /// <summary>
        /// Test UntagAssets
        /// </summary>
        [Fact]
        public void UntagAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //AssetIdsDto assetIdsDto = null;
            //var response = instance.UntagAssets(id, assetIdsDto);
            //Assert.IsType<List<AssetIdsResponseDto>>(response);
        }

        /// <summary>
        /// Test UpdateTag
        /// </summary>
        [Fact]
        public void UpdateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //UpdateTagDto updateTagDto = null;
            //var response = instance.UpdateTag(id, updateTagDto);
            //Assert.IsType<TagResponseDto>(response);
        }
    }
}
