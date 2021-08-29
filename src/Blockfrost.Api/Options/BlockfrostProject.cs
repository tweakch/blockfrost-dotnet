﻿namespace Blockfrost.Api.Options
{
    public class BlockfrostProject
    {
        public string ApiKey { get; set; }
        public string Name { get; set; }
        public string Network { get; set; }
        public string ConnectionLimit { get; set; } = "4";
    }
}
