using System;

public class Result
{
    public string symbol { get; set; }
    public string currency { get; set; }
    public float twoHundredDayAverage { get; set; }
    public float twoHundredDayAverageChange { get; set; }
    public float twoHundredDayAverageChangePercent { get; set; }
    public long marketCap { get; set; }
    public string shortName { get; set; }
    public string longName { get; set; }
    public float regularMarketChange { get; set; }
    public float regularMarketChangePercent { get; set; }
    public string regularMarketTime { get; set; } = string.Empty;
    public float regularMarketPrice { get; set; }
    public float regularMarketDayHigh { get; set; }
    public string regularMarketDayRange { get; set; } = string.Empty;
    public float regularMarketDayLow { get; set; }
    public int regularMarketVolume { get; set; }
    public float regularMarketPreviousClose { get; set; }
    public float regularMarketOpen { get; set; }
    public int averageDailyVolume3Month { get; set; }
    public int averageDailyVolume10Day { get; set; }
    public float fiftyTwoWeekLowChange { get; set; }
    public float? fiftyTwoWeekLowChangePercent { get; set; }
    public string fiftyTwoWeekRange { get; set; } = string.Empty;
    public float fiftyTwoWeekHighChange { get; set; }
    public float fiftyTwoWeekHighChangePercent { get; set; }
    public float fiftyTwoWeekLow { get; set; }
    public float fiftyTwoWeekHigh { get; set; }
    public float? priceEarnings { get; set; }
    public float earningsPerShare { get; set; }
    public string logourl { get; set; } = string.Empty;
    public string updatedAt { get; set; } = string.Empty;
}