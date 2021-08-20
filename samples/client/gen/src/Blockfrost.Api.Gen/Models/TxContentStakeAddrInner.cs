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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;


namespace Blockfrost.Api.Gen.Models
{
    /// <summary>
    /// TxContentStakeAddrInner
    /// </summary>
    [DataContract]
        public partial class TxContentStakeAddrInner :  IEquatable<TxContentStakeAddrInner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TxContentStakeAddrInner" /> class.
        /// </summary>
        /// <param name="certIndex">Index of the certificate within the transaction (required).</param>
        /// <param name="address">Delegation stake address (required).</param>
        /// <param name="registration">Registration boolean, false if deregistration (required).</param>
        public TxContentStakeAddrInner(int? certIndex = default(int?), string address = default(string), bool? registration = default(bool?))
        {
            // to ensure "certIndex" is required (not null)
            if (certIndex == null)
            {
                throw new InvalidDataException("certIndex is a required property for TxContentStakeAddrInner and cannot be null");
            }
            else
            {
                this.CertIndex = certIndex;
            }
            
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for TxContentStakeAddrInner and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            
            // to ensure "registration" is required (not null)
            if (registration == null)
            {
                throw new InvalidDataException("registration is a required property for TxContentStakeAddrInner and cannot be null");
            }
            else
            {
                this.Registration = registration;
            }
            
        }
        
        /// <summary>
        /// Index of the certificate within the transaction
        /// </summary>
        /// <value>Index of the certificate within the transaction</value>
        [Required]   
        [DataMember(Name="cert_index", EmitDefaultValue=false)]
        [JsonPropertyName("cert_index")]
        public int? CertIndex { get; set; }

        /// <summary>
        /// Delegation stake address
        /// </summary>
        /// <value>Delegation stake address</value>
        [Required]   
        [DataMember(Name="address", EmitDefaultValue=false)]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Registration boolean, false if deregistration
        /// </summary>
        /// <value>Registration boolean, false if deregistration</value>
        [Required]   
        [DataMember(Name="registration", EmitDefaultValue=false)]
        [JsonPropertyName("registration")]
        public bool? Registration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxContentStakeAddrInner {\n");
            sb.Append("  CertIndex: ").Append(CertIndex).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Registration: ").Append(Registration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson(JsonSerializerOptions options = null)
        {
            return JsonSerializer.Serialize(this, options);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TxContentStakeAddrInner);
        }

        /// <summary>
        /// Returns true if TxContentStakeAddrInner instances are equal
        /// </summary>
        /// <param name="input">Instance of TxContentStakeAddrInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TxContentStakeAddrInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CertIndex == input.CertIndex ||
                    (this.CertIndex != null && this.CertIndex.Equals(input.CertIndex))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null && this.Address.Equals(input.Address))
                ) && 
                (
                    this.Registration == input.Registration ||
                    (this.Registration != null && this.Registration.Equals(input.Registration))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CertIndex != null)
                    hashCode = hashCode * 59 + this.CertIndex.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Registration != null)
                    hashCode = hashCode * 59 + this.Registration.GetHashCode();
                return hashCode;
            }
        }
    }
}
