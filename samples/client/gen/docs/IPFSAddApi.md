# Blockfrost.Api.Gen.Api.IPFSAddApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IpfsAddPost**](IPFSAddApi.md#ipfsaddpost) | **POST** /ipfs/add | Add a file to IPFS

<a name="ipfsaddpost"></a>
# **IpfsAddPost**
> InlineResponse2004 IpfsAddPost ()

Add a file to IPFS

You need to `/ipfs/pin/add` an object to avoid it being garbage collected. This usage is being counted in your user account quota. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class IpfsAddPostExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new IPFSAddApi();

            try
            {
                // Add a file to IPFS
                InlineResponse2004 result = apiInstance.IpfsAddPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IPFSAddApi.IpfsAddPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
