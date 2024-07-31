# ImmichApi.Api.AuditApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAuditDeletes**](AuditApi.md#getauditdeletes) | **GET** /audit/deletes |  |

<a id="getauditdeletes"></a>
# **GetAuditDeletes**
> AuditDeletesResponseDto GetAuditDeletes (DateTime after, EntityType entityType, Guid? userId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ImmichApi.Api;
using ImmichApi.Client;
using ImmichApi.Model;

namespace Example
{
    public class GetAuditDeletesExample
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

            var apiInstance = new AuditApi(config);
            var after = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var entityType = (EntityType) "ASSET";  // EntityType | 
            var userId = "userId_example";  // Guid? |  (optional) 

            try
            {
                AuditDeletesResponseDto result = apiInstance.GetAuditDeletes(after, entityType, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuditApi.GetAuditDeletes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuditDeletesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AuditDeletesResponseDto> response = apiInstance.GetAuditDeletesWithHttpInfo(after, entityType, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuditApi.GetAuditDeletesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **after** | **DateTime** |  |  |
| **entityType** | **EntityType** |  |  |
| **userId** | **Guid?** |  | [optional]  |

### Return type

[**AuditDeletesResponseDto**](AuditDeletesResponseDto.md)

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

