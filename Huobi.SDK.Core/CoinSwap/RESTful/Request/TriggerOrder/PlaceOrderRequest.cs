﻿using Newtonsoft.Json;

namespace Huobi.SDK.Core.CoinSwap.RESTful.Request.TriggerOrder
{
    public class PlaceOrderRequest 
    {
        [JsonProperty("contract_code")]
        public string contractCode { get; set; }
        
        [JsonProperty("trigger_type")]
        public string triggerType { get; set; }

        [JsonProperty("trigger_price")]
        public double triggerPrice { get; set; }

        [JsonProperty("order_price")]
        public double? orderPrice { get; set; }

        [JsonProperty("order_price_type")]
        public string orderPriceType { get; set; }

        public long volume { get; set; }

        public string direction { get; set; }

        public string offset { get; set; }

        [JsonProperty("lever_rate")]
        public int? leverRate { get; set; }
    }
}
