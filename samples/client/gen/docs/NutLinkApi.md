# Blockfrost.Api.Gen.Services.NutLinkApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NutlinkAddressGet**](NutLinkApi.md#nutlinkaddressget) | **GET** /nutlink/{address} | 
[**NutlinkAddressTickersGet**](NutLinkApi.md#nutlinkaddresstickersget) | **GET** /nutlink/{address}/tickers | 
[**NutlinkAddressTickersTickerGet**](NutLinkApi.md#nutlinkaddresstickerstickerget) | **GET** /nutlink/{address}/tickers/{ticker} | 
[**NutlinkTickersTickerGet**](NutLinkApi.md#nutlinktickerstickerget) | **GET** /nutlink/tickers/{ticker} | 

<a name="nutlinkaddressget"></a>
# **NutlinkAddressGet**
> NutlinkAddress NutlinkAddressGet (string address)



List metadata about specific address

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class NutlinkAddressGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new NutLinkApi();
            var address = address_example;  // string | 

            try
            {
                NutlinkAddress result = apiInstance.NutlinkAddressGet(address);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NutLinkApi.NutlinkAddressGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**|  | 

### Return type

[**NutlinkAddress**](NutlinkAddress.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="nutlinkaddresstickersget"></a>
# **NutlinkAddressTickersGet**
> NutlinkAddressTickers NutlinkAddressTickersGet (string address, int? count = null, int? page = null, string order = null)



List tickers for a specific metadata oracle

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class NutlinkAddressTickersGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new NutLinkApi();
            var address = address_example;  // string | 
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                NutlinkAddressTickers result = apiInstance.NutlinkAddressTickersGet(address, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NutLinkApi.NutlinkAddressTickersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**|  | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**NutlinkAddressTickers**](NutlinkAddressTickers.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="nutlinkaddresstickerstickerget"></a>
# **NutlinkAddressTickersTickerGet**
> NutlinkAddressTicker NutlinkAddressTickersTickerGet (string address, string ticker, int? count = null, int? page = null, string order = null)



List of records of a specific ticker

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class NutlinkAddressTickersTickerGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new NutLinkApi();
            var address = address_example;  // string | 
            var ticker = ticker_example;  // string | 
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                NutlinkAddressTicker result = apiInstance.NutlinkAddressTickersTickerGet(address, ticker, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NutLinkApi.NutlinkAddressTickersTickerGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**|  | 
 **ticker** | **string**|  | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**NutlinkAddressTicker**](NutlinkAddressTicker.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="nutlinktickerstickerget"></a>
# **NutlinkTickersTickerGet**
> NutlinkTickersTicker NutlinkTickersTickerGet (string ticker, int? count = null, int? page = null, string order = null)



List of records of a specific ticker

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Gen.Services;
using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Model;

namespace Example
{
    public class NutlinkTickersTickerGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new NutLinkApi();
            var ticker = ticker_example;  // string | 
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                NutlinkTickersTicker result = apiInstance.NutlinkTickersTickerGet(ticker, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NutLinkApi.NutlinkTickersTickerGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ticker** | **string**|  | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**NutlinkTickersTicker**](NutlinkTickersTicker.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
