﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Blockfrost.Api
{
    /// <summary>The sum of all the UTXO per asset</summary>

    public partial class Output_amount
    {
        /// <summary>The quantity of the unit</summary>
        [JsonPropertyName("quantity")]
        [Required(AllowEmptyStrings = true)]
        public string Quantity { get; set; }

        /// <summary>The unit of the value</summary>
        [JsonPropertyName("unit")]
        [Required(AllowEmptyStrings = true)]
        public string Unit { get; set; }
    }
}
