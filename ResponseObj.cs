using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("host")]
    public string host { get; set; }

    [JsonProperty("numericHost")]
    public string numericHost { get; set; }

    [JsonProperty("alive")]
    public bool alive { get; set; }

    [JsonProperty("roundTrips")]
    public int roundTrips { get; set; }

    [JsonProperty("packetLoss")]
    public int packetLoss { get; set; }

    [JsonProperty("minMS")]
    public double minMS { get; set; }

    [JsonProperty("avgMS")]
    public double avgMS { get; set; }

    [JsonProperty("maxMS")]
    public double maxMS { get; set; }

    [JsonProperty("stdDev")]
    public double stdDev { get; set; }

    [JsonProperty("times")]
    public double[] times { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
