using Coins.server.DTO;
using System.Text.Json;

namespace Coins.server.Service
{
    public class CoinsService
    {
    DataCoins _allCoins;
    public CoinsService()
    {
      string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");



      string jsonString = File.ReadAllText(path);
      _allCoins = JsonSerializer.Deserialize<DataCoins>(jsonString);
    }
    public List<string> getLists () 
        {
     

            if (_allCoins == null) { return null; }

            return _allCoins.db.Select(c=>c.id).ToList();

        }

        public CoinDTO   getID(string id)
        {

          
            if (_allCoins == null) { return null; }
            return _allCoins.db.Where(c=>c.id==id).FirstOrDefault<CoinDTO>();

        }

    public bool  add(CoinDTO dto )
    {

     
     
      if (_allCoins == null) { return false; }
      _allCoins.db.Add(dto);
      string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
      var data= JsonSerializer.Serialize(_allCoins);
      File.WriteAllText(path, data);
      return true;

    }
  }
}
