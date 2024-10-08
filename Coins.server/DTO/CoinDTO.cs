namespace Coins.server.DTO
{
    public class CoinDTO
    {
       public string id { get; set; }
        public string  rank { get; set; }
        public string  symbol { get; set; }

        public string name { get; set; }
     
      //"supply": "19481743.0000000000000000",
      //"maxSupply": "21000000.0000000000000000",
      //"marketCapUsd": "504960188356.0773454615506801",
      //"volumeUsd24Hr": "1997236445.6363338420340092",
      //"priceUsd": "25919.6617241115102207",
      //"changePercent24Hr": "-0.0030895635910365",
      //"vwap24Hr": "25766.4336947052689790",
     public string  explorer { get; set; }

    }


    public class DataCoins
    {
        public List<CoinDTO> db { get; set; }



      
    }
}
