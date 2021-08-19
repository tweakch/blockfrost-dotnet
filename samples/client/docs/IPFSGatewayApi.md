# IO.Swagger.Api.IPFSGatewayApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IpfsGatewayIPFSPathGet**](IPFSGatewayApi.md#ipfsgatewayipfspathget) | **GET** /ipfs/gateway/{IPFS_path} | Relay to an IPFS gateway

<a name="ipfsgatewayipfspathget"></a>
# **IpfsGatewayIPFSPathGet**
> void IpfsGatewayIPFSPathGet (string iPFSPath)

Relay to an IPFS gateway

Retrieve an object from the IFPS gateway (useful if you do not want to rely on a public gateway, such as `ipfs.blockfrost.dev`).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IpfsGatewayIPFSPathGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new IPFSGatewayApi();
            var iPFSPath = iPFSPath_example;  // string | 

            try
            {
                // Relay to an IPFS gateway
                apiInstance.IpfsGatewayIPFSPathGet(iPFSPath);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFSGatewayApi.IpfsGatewayIPFSPathGet: " + e.Message );
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

void (empty response body)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
