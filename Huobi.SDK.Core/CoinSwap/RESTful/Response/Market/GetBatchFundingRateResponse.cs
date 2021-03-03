﻿
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Huobi.SDK.Core.CoinSwap.RESTful.Response.Market
{
    /// <summary>
    /// response for batch funding rate request
    /// </summary>
    public class GetBatchFundingRateResponse
    {
        public string status { get; set; }

        [JsonProperty("err_code", NullValueHandling = NullValueHandling.Ignore)]
        public string errorCode { get; set; }

        [JsonProperty("err_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string errorMessage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Data> data { get; set; }

        public long ts { get; set; }

        public class Data
        {
            public string symbol { get; set; }

            [JsonProperty("contract_code")]
            public string contractCode { get; set; }

            [JsonProperty("fee_asset")]
            public string feeAsset { get; set; }

            [JsonProperty("funding_time")]
            public string fundingTime { get; set; }

            [JsonProperty("funding_rate")]
            public string fundingRate { get; set; }

            [JsonProperty("estimated_rate")]
            public string estimatedRate { get; set; }

            [JsonProperty("next_funding_time")]
            public string nextFundingTime { get; set; }
        }
    }
}
