/* 
 * Blockfrost.io ~ API Documentation
 *
 * Blockfrost is an API as a service that allows users to interact with the Cardano blockchain and parts of its ecosystem.  ## Tokens  After signing up on https://blockfrost.io, a `project_id` token is automatically generated for each project. HTTP header of your request MUST include this `project_id` in order to authenticate against Blockfrost servers.  ## Available networks  At the moment, you can use the following networks. Please, note that each network has its own `project_id`.  <table>   <tr><td><b>Network</b></td><td><b>Endpoint</b></td></tr>   <tr><td>Cardano mainnet</td><td><tt>https://cardano-mainnet.blockfrost.io/api/v0</td></tt></tr>   <tr><td>Cardano testnet</td><td><tt>https://cardano-testnet.blockfrost.io/api/v0</tt></td></tr>   <tr><td>InterPlanetary File System</td><td><tt>https://ipfs.blockfrost.io/api/v0</tt></td></tr> </table>  ## Concepts  * All endpoints return either a JSON object or an array. * Data is returned in *ascending* (oldest first, newest last) order.   * You might use the `?order=desc` query parameter to reverse this order. * By default, we return 100 results at a time. You have to use `?page=2` to list through the results. * All time and timestamp related fields (except `server_time`) are in seconds of UNIX time. * All amounts are returned in Lovelaces, where 1 ADA = 1 000 000 Lovelaces. * Addresses, accounts and pool IDs are in Bech32 format. * All values are case sensitive. * All hex encoded values are lower case. * Examples are not based on real data. Any resemblance to actual events is purely coincidental. * We allow to upload files up to 100MB of size to IPFS. This might increase in the future.  ## Errors  ### HTTP Status codes  The following are HTTP status code your application might receive when reaching Blockfrost endpoints and it should handle all of these cases.  * HTTP `400` return code is used when the request is not valid. * HTTP `402` return code is used when the projects exceed their daily request limit. * HTTP `403` return code is used when the request is not authenticated. * HTTP `404` return code is used when the resource doesn't exist. * HTTP `418` return code is used when the user has been auto-banned for flooding too much after previously receiving error code `402` or `429`. * HTTP `429` return code is used when the user has sent too many requests in a given amount of time and therefore has been rate-limited. * HTTP `500` return code is used when our endpoints are having a problem.  ### Error codes  An internal error code number is used for better indication of the error in question. It is passed using the following payload.  ```json {   \"status_code\": 403,   \"error\": \"Forbidden\",   \"message\": \"Invalid project token.\" } ``` ## Limits   There are two types of limits we are enforcing:   The first depends on your plan and is the number of request we allow per day. We defined the day from midnight to midnight of UTC time.   The second is rate limiting. We limit an end user, distinguished by IP address, to 10 requests per second. On top of that, we allow  each user to send burst of 500 requests, which cools off at rate of 10 requests per second. In essence, a user is allowed to make another  whole burst after (currently) 500/10 = 50 seconds. E.g. if a user attemtps to make a call 3 seconds after whole burst, 30 requests will be processed.  We believe this should be sufficient for most of the use cases. If it is not and you have a specific use case, please get in touch with us, and  we will make sure to take it into account as much as we can.   ## SDKs  We support a number of SDKs that will help you in developing your application on top of Blockfrost.  <table>   <tr><td><b>Programming language</b></td><td><b>SDK</b></td></tr>   <tr><td>JavaScript</td><td><a href=\"https://github.com/blockfrost/blockfrost-js\">blockfrost-js</a></tr> </table> 
 *
 * OpenAPI spec version: 0.1.26
 * Contact: contact@blockfrost.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
// using NUnit.Framework;

using Blockfrost.Api.Gen.Client;
using Blockfrost.Api.Gen.Api;
using Blockfrost.Api.Gen.Model;

namespace Blockfrost.Api.Gen.Test
{
    /// <summary>
    ///  Class for testing CardanoAccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CardanoAccountsApiTests
    {
        private CardanoAccountsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CardanoAccountsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CardanoAccountsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CardanoAccountsApi
            //Assert.IsInstanceOfType(typeof(CardanoAccountsApi), instance, "instance is a CardanoAccountsApi");
        }

        /// <summary>
        /// Test AccountsStakeAddressAddressesAssetsGet
        /// </summary>
        [Test]
        public void AccountsStakeAddressAddressesAssetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stakeAddress = null;
            //int? count = null;
            //int? page = null;
            //string order = null;
            //var response = instance.AccountsStakeAddressAddressesAssetsGet(stakeAddress, count, page, order);
            //Assert.IsInstanceOf<AccountAddressesAssets> (response, "response is AccountAddressesAssets");
        }
        /// <summary>
        /// Test AccountsStakeAddressAddressesGet
        /// </summary>
        [Test]
        public void AccountsStakeAddressAddressesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stakeAddress = null;
            //int? count = null;
            //int? page = null;
            //string order = null;
            //var response = instance.AccountsStakeAddressAddressesGet(stakeAddress, count, page, order);
            //Assert.IsInstanceOf<AccountAddressesContent> (response, "response is AccountAddressesContent");
        }
        /// <summary>
        /// Test AccountsStakeAddressDelegationsGet
        /// </summary>
        [Test]
        public void AccountsStakeAddressDelegationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stakeAddress = null;
            //int? count = null;
            //int? page = null;
            //string order = null;
            //var response = instance.AccountsStakeAddressDelegationsGet(stakeAddress, count, page, order);
            //Assert.IsInstanceOf<AccountDelegationContent> (response, "response is AccountDelegationContent");
        }
        /// <summary>
        /// Test AccountsStakeAddressGet
        /// </summary>
        [Test]
        public void AccountsStakeAddressGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stakeAddress = null;
            //var response = instance.AccountsStakeAddressGet(stakeAddress);
            //Assert.IsInstanceOf<AccountContent> (response, "response is AccountContent");
        }
        /// <summary>
        /// Test AccountsStakeAddressHistoryGet
        /// </summary>
        [Test]
        public void AccountsStakeAddressHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stakeAddress = null;
            //int? count = null;
            //int? page = null;
            //string order = null;
            //var response = instance.AccountsStakeAddressHistoryGet(stakeAddress, count, page, order);
            //Assert.IsInstanceOf<AccountHistoryContent> (response, "response is AccountHistoryContent");
        }
        /// <summary>
        /// Test AccountsStakeAddressMirsGet
        /// </summary>
        [Test]
        public void AccountsStakeAddressMirsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stakeAddress = null;
            //int? count = null;
            //int? page = null;
            //string order = null;
            //var response = instance.AccountsStakeAddressMirsGet(stakeAddress, count, page, order);
            //Assert.IsInstanceOf<AccountMirContent> (response, "response is AccountMirContent");
        }
        /// <summary>
        /// Test AccountsStakeAddressRegistrationsGet
        /// </summary>
        [Test]
        public void AccountsStakeAddressRegistrationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stakeAddress = null;
            //int? count = null;
            //int? page = null;
            //string order = null;
            //var response = instance.AccountsStakeAddressRegistrationsGet(stakeAddress, count, page, order);
            //Assert.IsInstanceOf<AccountRegistrationContent> (response, "response is AccountRegistrationContent");
        }
        /// <summary>
        /// Test AccountsStakeAddressRewardsGet
        /// </summary>
        [Test]
        public void AccountsStakeAddressRewardsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stakeAddress = null;
            //int? count = null;
            //int? page = null;
            //string order = null;
            //var response = instance.AccountsStakeAddressRewardsGet(stakeAddress, count, page, order);
            //Assert.IsInstanceOf<AccountRewardContent> (response, "response is AccountRewardContent");
        }
        /// <summary>
        /// Test AccountsStakeAddressWithdrawalsGet
        /// </summary>
        [Test]
        public void AccountsStakeAddressWithdrawalsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string stakeAddress = null;
            //int? count = null;
            //int? page = null;
            //string order = null;
            //var response = instance.AccountsStakeAddressWithdrawalsGet(stakeAddress, count, page, order);
            //Assert.IsInstanceOf<AccountWithdrawalContent> (response, "response is AccountWithdrawalContent");
        }
    }

}
