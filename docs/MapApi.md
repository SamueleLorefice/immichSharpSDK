# ImmichApi.Api.MapApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMapMarkers**](MapApi.md#getmapmarkers) | **GET** /map/markers |  |
| [**GetMapStyle**](MapApi.md#getmapstyle) | **GET** /map/style.json |  |
| [**ReverseGeocode**](MapApi.md#reversegeocode) | **GET** /map/reverse-geocode |  |

<a id="getmapmarkers"></a>
# **GetMapMarkers**
> List&lt;MapMarkerResponseDto&gt; GetMapMarkers (DateTime? fileCreatedAfter = null, DateTime? fileCreatedBefore = null, bool? isArchived = null, bool? isFavorite = null, bool? withPartners = null, bool? withSharedAlbums = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ImmichApi.Api;
using ImmichApi.Client;
using ImmichApi.Model;

namespace Example
{
    public class GetMapMarkersExample
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

            var apiInstance = new MapApi(config);
            var fileCreatedAfter = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var fileCreatedBefore = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var isArchived = true;  // bool? |  (optional) 
            var isFavorite = true;  // bool? |  (optional) 
            var withPartners = true;  // bool? |  (optional) 
            var withSharedAlbums = true;  // bool? |  (optional) 

            try
            {
                List<MapMarkerResponseDto> result = apiInstance.GetMapMarkers(fileCreatedAfter, fileCreatedBefore, isArchived, isFavorite, withPartners, withSharedAlbums);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MapApi.GetMapMarkers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMapMarkersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<MapMarkerResponseDto>> response = apiInstance.GetMapMarkersWithHttpInfo(fileCreatedAfter, fileCreatedBefore, isArchived, isFavorite, withPartners, withSharedAlbums);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MapApi.GetMapMarkersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileCreatedAfter** | **DateTime?** |  | [optional]  |
| **fileCreatedBefore** | **DateTime?** |  | [optional]  |
| **isArchived** | **bool?** |  | [optional]  |
| **isFavorite** | **bool?** |  | [optional]  |
| **withPartners** | **bool?** |  | [optional]  |
| **withSharedAlbums** | **bool?** |  | [optional]  |

### Return type

[**List&lt;MapMarkerResponseDto&gt;**](MapMarkerResponseDto.md)

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

<a id="getmapstyle"></a>
# **GetMapStyle**
> Object GetMapStyle (MapTheme theme, string? key = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ImmichApi.Api;
using ImmichApi.Client;
using ImmichApi.Model;

namespace Example
{
    public class GetMapStyleExample
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

            var apiInstance = new MapApi(config);
            var theme = (MapTheme) "light";  // MapTheme | 
            var key = "key_example";  // string? |  (optional) 

            try
            {
                Object result = apiInstance.GetMapStyle(theme, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MapApi.GetMapStyle: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMapStyleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.GetMapStyleWithHttpInfo(theme, key);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MapApi.GetMapStyleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **theme** | **MapTheme** |  |  |
| **key** | **string?** |  | [optional]  |

### Return type

**Object**

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

<a id="reversegeocode"></a>
# **ReverseGeocode**
> List&lt;MapReverseGeocodeResponseDto&gt; ReverseGeocode (double lat, double lon)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ImmichApi.Api;
using ImmichApi.Client;
using ImmichApi.Model;

namespace Example
{
    public class ReverseGeocodeExample
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

            var apiInstance = new MapApi(config);
            var lat = 1.2D;  // double | 
            var lon = 1.2D;  // double | 

            try
            {
                List<MapReverseGeocodeResponseDto> result = apiInstance.ReverseGeocode(lat, lon);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MapApi.ReverseGeocode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReverseGeocodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<MapReverseGeocodeResponseDto>> response = apiInstance.ReverseGeocodeWithHttpInfo(lat, lon);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MapApi.ReverseGeocodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lat** | **double** |  |  |
| **lon** | **double** |  |  |

### Return type

[**List&lt;MapReverseGeocodeResponseDto&gt;**](MapReverseGeocodeResponseDto.md)

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

