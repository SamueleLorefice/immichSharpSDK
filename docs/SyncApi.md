# ImmichApi.Api.SyncApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDeltaSync**](SyncApi.md#getdeltasync) | **POST** /sync/delta-sync |  |
| [**GetFullSyncForUser**](SyncApi.md#getfullsyncforuser) | **POST** /sync/full-sync |  |

<a id="getdeltasync"></a>
# **GetDeltaSync**
> AssetDeltaSyncResponseDto GetDeltaSync (AssetDeltaSyncDto assetDeltaSyncDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ImmichApi.Api;
using ImmichApi.Client;
using ImmichApi.Model;

namespace Example
{
    public class GetDeltaSyncExample
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

            var apiInstance = new SyncApi(config);
            var assetDeltaSyncDto = new AssetDeltaSyncDto(); // AssetDeltaSyncDto | 

            try
            {
                AssetDeltaSyncResponseDto result = apiInstance.GetDeltaSync(assetDeltaSyncDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SyncApi.GetDeltaSync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeltaSyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AssetDeltaSyncResponseDto> response = apiInstance.GetDeltaSyncWithHttpInfo(assetDeltaSyncDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SyncApi.GetDeltaSyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetDeltaSyncDto** | [**AssetDeltaSyncDto**](AssetDeltaSyncDto.md) |  |  |

### Return type

[**AssetDeltaSyncResponseDto**](AssetDeltaSyncResponseDto.md)

### Authorization

[cookie](../README.md#cookie), [api_key](../README.md#api_key), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfullsyncforuser"></a>
# **GetFullSyncForUser**
> List&lt;AssetResponseDto&gt; GetFullSyncForUser (AssetFullSyncDto assetFullSyncDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ImmichApi.Api;
using ImmichApi.Client;
using ImmichApi.Model;

namespace Example
{
    public class GetFullSyncForUserExample
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

            var apiInstance = new SyncApi(config);
            var assetFullSyncDto = new AssetFullSyncDto(); // AssetFullSyncDto | 

            try
            {
                List<AssetResponseDto> result = apiInstance.GetFullSyncForUser(assetFullSyncDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SyncApi.GetFullSyncForUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFullSyncForUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<AssetResponseDto>> response = apiInstance.GetFullSyncForUserWithHttpInfo(assetFullSyncDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SyncApi.GetFullSyncForUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **assetFullSyncDto** | [**AssetFullSyncDto**](AssetFullSyncDto.md) |  |  |

### Return type

[**List&lt;AssetResponseDto&gt;**](AssetResponseDto.md)

### Authorization

[cookie](../README.md#cookie), [api_key](../README.md#api_key), [bearer](../README.md#bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

