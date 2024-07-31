# ImmichApi.Api.TimelineApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTimeBucket**](TimelineApi.md#gettimebucket) | **GET** /timeline/bucket |  |
| [**GetTimeBuckets**](TimelineApi.md#gettimebuckets) | **GET** /timeline/buckets |  |

<a id="gettimebucket"></a>
# **GetTimeBucket**
> List&lt;AssetResponseDto&gt; GetTimeBucket (TimeBucketSize size, string timeBucket, Guid? albumId = null, bool? isArchived = null, bool? isFavorite = null, bool? isTrashed = null, string? key = null, AssetOrder? order = null, Guid? personId = null, Guid? userId = null, bool? withPartners = null, bool? withStacked = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ImmichApi.Api;
using ImmichApi.Client;
using ImmichApi.Model;

namespace Example
{
    public class GetTimeBucketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // Configure API key authorization: cookie
            config.AddApiKey("immich_access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("immich_access_token", "Bearer");
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimelineApi(config);
            var size = (TimeBucketSize) "DAY";  // TimeBucketSize | 
            var timeBucket = "timeBucket_example";  // string | 
            var albumId = "albumId_example";  // Guid? |  (optional) 
            var isArchived = true;  // bool? |  (optional) 
            var isFavorite = true;  // bool? |  (optional) 
            var isTrashed = true;  // bool? |  (optional) 
            var key = "key_example";  // string? |  (optional) 
            var order = new AssetOrder?(); // AssetOrder? |  (optional) 
            var personId = "personId_example";  // Guid? |  (optional) 
            var userId = "userId_example";  // Guid? |  (optional) 
            var withPartners = true;  // bool? |  (optional) 
            var withStacked = true;  // bool? |  (optional) 

            try
            {
                List<AssetResponseDto> result = apiInstance.GetTimeBucket(size, timeBucket, albumId, isArchived, isFavorite, isTrashed, key, order, personId, userId, withPartners, withStacked);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimelineApi.GetTimeBucket: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTimeBucketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AssetResponseDto>> response = apiInstance.GetTimeBucketWithHttpInfo(size, timeBucket, albumId, isArchived, isFavorite, isTrashed, key, order, personId, userId, withPartners, withStacked);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimelineApi.GetTimeBucketWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **size** | **TimeBucketSize** |  |  |
| **timeBucket** | **string** |  |  |
| **albumId** | **Guid?** |  | [optional]  |
| **isArchived** | **bool?** |  | [optional]  |
| **isFavorite** | **bool?** |  | [optional]  |
| **isTrashed** | **bool?** |  | [optional]  |
| **key** | **string?** |  | [optional]  |
| **order** | [**AssetOrder?**](AssetOrder?.md) |  | [optional]  |
| **personId** | **Guid?** |  | [optional]  |
| **userId** | **Guid?** |  | [optional]  |
| **withPartners** | **bool?** |  | [optional]  |
| **withStacked** | **bool?** |  | [optional]  |

### Return type

[**List&lt;AssetResponseDto&gt;**](AssetResponseDto.md)

### Authorization

[cookie](../README.md#cookie), [api_key](../README.md#api_key), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettimebuckets"></a>
# **GetTimeBuckets**
> List&lt;TimeBucketResponseDto&gt; GetTimeBuckets (TimeBucketSize size, Guid? albumId = null, bool? isArchived = null, bool? isFavorite = null, bool? isTrashed = null, string? key = null, AssetOrder? order = null, Guid? personId = null, Guid? userId = null, bool? withPartners = null, bool? withStacked = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ImmichApi.Api;
using ImmichApi.Client;
using ImmichApi.Model;

namespace Example
{
    public class GetTimeBucketsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // Configure API key authorization: cookie
            config.AddApiKey("immich_access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("immich_access_token", "Bearer");
            // Configure API key authorization: api_key
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TimelineApi(config);
            var size = (TimeBucketSize) "DAY";  // TimeBucketSize | 
            var albumId = "albumId_example";  // Guid? |  (optional) 
            var isArchived = true;  // bool? |  (optional) 
            var isFavorite = true;  // bool? |  (optional) 
            var isTrashed = true;  // bool? |  (optional) 
            var key = "key_example";  // string? |  (optional) 
            var order = new AssetOrder?(); // AssetOrder? |  (optional) 
            var personId = "personId_example";  // Guid? |  (optional) 
            var userId = "userId_example";  // Guid? |  (optional) 
            var withPartners = true;  // bool? |  (optional) 
            var withStacked = true;  // bool? |  (optional) 

            try
            {
                List<TimeBucketResponseDto> result = apiInstance.GetTimeBuckets(size, albumId, isArchived, isFavorite, isTrashed, key, order, personId, userId, withPartners, withStacked);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TimelineApi.GetTimeBuckets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTimeBucketsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<TimeBucketResponseDto>> response = apiInstance.GetTimeBucketsWithHttpInfo(size, albumId, isArchived, isFavorite, isTrashed, key, order, personId, userId, withPartners, withStacked);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TimelineApi.GetTimeBucketsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **size** | **TimeBucketSize** |  |  |
| **albumId** | **Guid?** |  | [optional]  |
| **isArchived** | **bool?** |  | [optional]  |
| **isFavorite** | **bool?** |  | [optional]  |
| **isTrashed** | **bool?** |  | [optional]  |
| **key** | **string?** |  | [optional]  |
| **order** | [**AssetOrder?**](AssetOrder?.md) |  | [optional]  |
| **personId** | **Guid?** |  | [optional]  |
| **userId** | **Guid?** |  | [optional]  |
| **withPartners** | **bool?** |  | [optional]  |
| **withStacked** | **bool?** |  | [optional]  |

### Return type

[**List&lt;TimeBucketResponseDto&gt;**](TimeBucketResponseDto.md)

### Authorization

[cookie](../README.md#cookie), [api_key](../README.md#api_key), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

