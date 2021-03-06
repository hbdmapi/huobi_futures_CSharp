﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Huobi.SDK.Core.Futures.WS.Response.Market
{
    /// <summary>
    /// response for kline and detail sub
    /// </summary>
    public class SubKLineResponse
    {
        public string ch { get; set; }

        public long ts { get; set; }

        public Tick tick;

        public class Tick
        {
            public long id { get; set; }

            public long mrid { get; set; }

            public double vol { get; set; }

            public double count { get; set; }

            public double open { get; set; }

            public double close { get; set; }

            public double low { get; set; }

            public double high { get; set; }

            public double amount { get; set; }

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public double[] ask { get; set; }

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public double[] bid { get; set; }
        }
    }
}