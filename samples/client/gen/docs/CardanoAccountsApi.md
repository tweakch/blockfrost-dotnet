# Blockfrost.Api.Api.CardanoAccountsApi

All URIs are relative to *https://cardano-mainnet.blockfrost.io/api/v0/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsStakeAddressAddressesAssetsGet**](CardanoAccountsApi.md#accountsstakeaddressaddressesassetsget) | **GET** /accounts/{stake_address}/addresses/assets | Assets associated with the account addresses
[**AccountsStakeAddressAddressesGet**](CardanoAccountsApi.md#accountsstakeaddressaddressesget) | **GET** /accounts/{stake_address}/addresses | Account associated addresses
[**AccountsStakeAddressDelegationsGet**](CardanoAccountsApi.md#accountsstakeaddressdelegationsget) | **GET** /accounts/{stake_address}/delegations | Account delegation history
[**AccountsStakeAddressGet**](CardanoAccountsApi.md#accountsstakeaddressget) | **GET** /accounts/{stake_address} | Specific account address
[**AccountsStakeAddressHistoryGet**](CardanoAccountsApi.md#accountsstakeaddresshistoryget) | **GET** /accounts/{stake_address}/history | Account history
[**AccountsStakeAddressMirsGet**](CardanoAccountsApi.md#accountsstakeaddressmirsget) | **GET** /accounts/{stake_address}/mirs | Account MIR history
[**AccountsStakeAddressRegistrationsGet**](CardanoAccountsApi.md#accountsstakeaddressregistrationsget) | **GET** /accounts/{stake_address}/registrations | Account registration history
[**AccountsStakeAddressRewardsGet**](CardanoAccountsApi.md#accountsstakeaddressrewardsget) | **GET** /accounts/{stake_address}/rewards | Account reward history
[**AccountsStakeAddressWithdrawalsGet**](CardanoAccountsApi.md#accountsstakeaddresswithdrawalsget) | **GET** /accounts/{stake_address}/withdrawals | Account withdrawal history

<a name="accountsstakeaddressaddressesassetsget"></a>
# **AccountsStakeAddressAddressesAssetsGet**
> AccountAddressesAssets AccountsStakeAddressAddressesAssetsGet (string stakeAddress, int? count = null, int? page = null, string order = null)

Assets associated with the account addresses

Obtain information about assets associated with addresses of a specific account.  <b>Be careful</b>, as an account could be part of a mangled address and does not necessarily mean the addresses are owned by user as the account. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AccountsStakeAddressAddressesAssetsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAccountsApi();
            var stakeAddress = stakeAddress_example;  // string | Bech32 stake address.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Assets associated with the account addresses
                AccountAddressesAssets result = apiInstance.AccountsStakeAddressAddressesAssetsGet(stakeAddress, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAccountsApi.AccountsStakeAddressAddressesAssetsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeAddress** | **string**| Bech32 stake address. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AccountAddressesAssets**](AccountAddressesAssets.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsstakeaddressaddressesget"></a>
# **AccountsStakeAddressAddressesGet**
> AccountAddressesContent AccountsStakeAddressAddressesGet (string stakeAddress, int? count = null, int? page = null, string order = null)

Account associated addresses

Obtain information about the addresses of a specific account.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AccountsStakeAddressAddressesGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAccountsApi();
            var stakeAddress = stakeAddress_example;  // string | Bech32 stake address.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Account associated addresses
                AccountAddressesContent result = apiInstance.AccountsStakeAddressAddressesGet(stakeAddress, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAccountsApi.AccountsStakeAddressAddressesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeAddress** | **string**| Bech32 stake address. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AccountAddressesContent**](AccountAddressesContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsstakeaddressdelegationsget"></a>
# **AccountsStakeAddressDelegationsGet**
> AccountDelegationContent AccountsStakeAddressDelegationsGet (string stakeAddress, int? count = null, int? page = null, string order = null)

Account delegation history

Obtain information about the delegation of a specific account.

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AccountsStakeAddressDelegationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAccountsApi();
            var stakeAddress = stakeAddress_example;  // string | Bech32 stake address.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Account delegation history
                AccountDelegationContent result = apiInstance.AccountsStakeAddressDelegationsGet(stakeAddress, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAccountsApi.AccountsStakeAddressDelegationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeAddress** | **string**| Bech32 stake address. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AccountDelegationContent**](AccountDelegationContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsstakeaddressget"></a>
# **AccountsStakeAddressGet**
> AccountContent AccountsStakeAddressGet (string stakeAddress)

Specific account address

Obtain information about a specific stake account. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AccountsStakeAddressGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAccountsApi();
            var stakeAddress = stakeAddress_example;  // string | Bech32 stake address.

            try
            {
                // Specific account address
                AccountContent result = apiInstance.AccountsStakeAddressGet(stakeAddress);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAccountsApi.AccountsStakeAddressGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeAddress** | **string**| Bech32 stake address. | 

### Return type

[**AccountContent**](AccountContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsstakeaddresshistoryget"></a>
# **AccountsStakeAddressHistoryGet**
> AccountHistoryContent AccountsStakeAddressHistoryGet (string stakeAddress, int? count = null, int? page = null, string order = null)

Account history

Obtain information about the history of a specific account. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AccountsStakeAddressHistoryGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAccountsApi();
            var stakeAddress = stakeAddress_example;  // string | Bech32 stake address.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Account history
                AccountHistoryContent result = apiInstance.AccountsStakeAddressHistoryGet(stakeAddress, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAccountsApi.AccountsStakeAddressHistoryGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeAddress** | **string**| Bech32 stake address. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AccountHistoryContent**](AccountHistoryContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsstakeaddressmirsget"></a>
# **AccountsStakeAddressMirsGet**
> AccountMirContent AccountsStakeAddressMirsGet (string stakeAddress, int? count = null, int? page = null, string order = null)

Account MIR history

Obtain information about the MIRs of a specific account. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AccountsStakeAddressMirsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAccountsApi();
            var stakeAddress = stakeAddress_example;  // string | Bech32 stake address.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Account MIR history
                AccountMirContent result = apiInstance.AccountsStakeAddressMirsGet(stakeAddress, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAccountsApi.AccountsStakeAddressMirsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeAddress** | **string**| Bech32 stake address. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AccountMirContent**](AccountMirContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsstakeaddressregistrationsget"></a>
# **AccountsStakeAddressRegistrationsGet**
> AccountRegistrationContent AccountsStakeAddressRegistrationsGet (string stakeAddress, int? count = null, int? page = null, string order = null)

Account registration history

Obtain information about the registrations and deregistrations of a specific account. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AccountsStakeAddressRegistrationsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAccountsApi();
            var stakeAddress = stakeAddress_example;  // string | Bech32 stake address.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Account registration history
                AccountRegistrationContent result = apiInstance.AccountsStakeAddressRegistrationsGet(stakeAddress, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAccountsApi.AccountsStakeAddressRegistrationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeAddress** | **string**| Bech32 stake address. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AccountRegistrationContent**](AccountRegistrationContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsstakeaddressrewardsget"></a>
# **AccountsStakeAddressRewardsGet**
> AccountRewardContent AccountsStakeAddressRewardsGet (string stakeAddress, int? count = null, int? page = null, string order = null)

Account reward history

Obtain information about the reward history of a specific account. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AccountsStakeAddressRewardsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAccountsApi();
            var stakeAddress = stakeAddress_example;  // string | Bech32 stake address.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Account reward history
                AccountRewardContent result = apiInstance.AccountsStakeAddressRewardsGet(stakeAddress, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAccountsApi.AccountsStakeAddressRewardsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeAddress** | **string**| Bech32 stake address. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AccountRewardContent**](AccountRewardContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountsstakeaddresswithdrawalsget"></a>
# **AccountsStakeAddressWithdrawalsGet**
> AccountWithdrawalContent AccountsStakeAddressWithdrawalsGet (string stakeAddress, int? count = null, int? page = null, string order = null)

Account withdrawal history

Obtain information about the withdrawals of a specific account. 

### Example
```csharp
using System;
using System.Diagnostics;
using Blockfrost.Api.Api;
using Blockfrost.Api.Client;
using Blockfrost.Api.Model;

namespace Example
{
    public class AccountsStakeAddressWithdrawalsGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("project_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("project_id", "Bearer");

            var apiInstance = new CardanoAccountsApi();
            var stakeAddress = stakeAddress_example;  // string | Bech32 stake address.
            var count = 56;  // int? | The number of results displayed on one page. (optional)  (default to 100)
            var page = 56;  // int? | The page number for listing the results. (optional)  (default to 1)
            var order = order_example;  // string | The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  (optional)  (default to asc)

            try
            {
                // Account withdrawal history
                AccountWithdrawalContent result = apiInstance.AccountsStakeAddressWithdrawalsGet(stakeAddress, count, page, order);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardanoAccountsApi.AccountsStakeAddressWithdrawalsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stakeAddress** | **string**| Bech32 stake address. | 
 **count** | **int?**| The number of results displayed on one page. | [optional] [default to 100]
 **page** | **int?**| The page number for listing the results. | [optional] [default to 1]
 **order** | **string**| The ordering of items from the point of view of the blockchain, not the page listing itself. By default, we return oldest first, newest last.  | [optional] [default to asc]

### Return type

[**AccountWithdrawalContent**](AccountWithdrawalContent.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
