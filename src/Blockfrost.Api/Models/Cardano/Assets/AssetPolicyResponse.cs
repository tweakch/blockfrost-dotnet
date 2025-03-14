﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

//namespace Blockfrost.Api.Models.Cardano.Assets
namespace Blockfrost.Api
{
    public partial class AssetPolicyResponse
    {
        /// <summary>Concatenation of the policy_id and hex-encoded asset_name</summary>
        [JsonPropertyName("asset")]
        [Required(AllowEmptyStrings = true)]
        public string Asset { get; set; }

        /// <summary>Current asset quantity</summary>
        [JsonPropertyName("quantity")]
        [Required(AllowEmptyStrings = true)]
        public string Quantity { get; set; }
    }
}
