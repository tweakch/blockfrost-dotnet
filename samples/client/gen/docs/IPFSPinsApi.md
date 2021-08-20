# Blockfrost.Api.Gen.Services.IPFSPinsApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IpfsPinAddIPFSPathPost**](IPFSPinsApi.md#ipfspinaddipfspathpost) | **POST** /ipfs/pin/add/{IPFS_path} | Pin an object
[**IpfsPinListGet**](IPFSPinsApi.md#ipfspinlistget) | **GET** /ipfs/pin/list/ | List pinned objects
[**IpfsPinListIPFSPathGet**](IPFSPinsApi.md#ipfspinlistipfspathget) | **GET** /ipfs/pin/list/{IPFS_path} | Get details about pinned object
[**IpfsPinRemoveIPFSPathPost**](IPFSPinsApi.md#ipfspinremoveipfspathpost) | **POST** /ipfs/pin/remove/{IPFS_path} | 

<a name="ipfspinaddipfspathpost"></a>
# **IpfsPinAddIPFSPathPost**
> InlineResponse2005 IpfsPinAddIPFSPathPost (string iPFSPath)

Pin an object

Pinned objects are counted in your user storage quota.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class IpfsPinAddIPFSPathPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new IPFSPinsApi();
            var iPFSPath = iPFSPath_example;  // string | 

            try
            {
                // Pin an object
                InlineResponse2005 result = apiInstance.IpfsPinAddIPFSPathPost(iPFSPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFSPinsApi.IpfsPinAddIPFSPathPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iPFSPath** | **string**|  | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ipfspinlistget"></a>
# **IpfsPinListGet**
> List<InlineResponse2006> IpfsPinListGet (int? count = null, int? page = null, string order = null)

List pinned objects

List objects pinned to local storage

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class IpfsPinListGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new IPFSPinsApi();
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // List pinned objects
                List&lt;InlineResponse2006&gt; result = apiInstance.IpfsPinListGet(count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFSPinsApi.IpfsPinListGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**List<InlineResponse2006>**](InlineResponse2006.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ipfspinlistipfspathget"></a>
# **IpfsPinListIPFSPathGet**
> InlineResponse2007 IpfsPinListIPFSPathGet (string iPFSPath)

Get details about pinned object

Get information about locally pinned IPFS object

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class IpfsPinListIPFSPathGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new IPFSPinsApi();
            var iPFSPath = iPFSPath_example;  // string | 

            try
            {
                // Get details about pinned object
                InlineResponse2007 result = apiInstance.IpfsPinListIPFSPathGet(iPFSPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFSPinsApi.IpfsPinListIPFSPathGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iPFSPath** | **string**|  | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="ipfspinremoveipfspathpost"></a>
# **IpfsPinRemoveIPFSPathPost**
> InlineResponse2008 IpfsPinRemoveIPFSPathPost (string iPFSPath)



Remove pinned objects from local storage

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class IpfsPinRemoveIPFSPathPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new IPFSPinsApi();
            var iPFSPath = iPFSPath_example;  // string | 

            try
            {
                InlineResponse2008 result = apiInstance.IpfsPinRemoveIPFSPathPost(iPFSPath);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFSPinsApi.IpfsPinRemoveIPFSPathPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iPFSPath** | **string**|  | 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
