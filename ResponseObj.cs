using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("numericHost")]
        public string NumericHost { get; set; }

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("roundTrips")]
        public int RoundTrips { get; set; }

        [JsonProperty("packetLoss")]
        public int PacketLoss { get; set; }

        [JsonProperty("minMS")]
        public double MinMS { get; set; }

        [JsonProperty("avgMS")]
        public double AvgMS { get; set; }

        [JsonProperty("maxMS")]
        public double MaxMS { get; set; }

        [JsonProperty("stdDev")]
        public double StdDev { get; set; }

        [JsonProperty("times")]
        public double[] Times { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
