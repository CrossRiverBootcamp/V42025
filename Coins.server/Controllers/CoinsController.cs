using Coins.server.DTO;
using Coins.server.Service;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Coins.server.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CoinsController : ControllerBase
  {



    readonly CoinsService _coinsSerice;
    private object result;

    public CoinsController()
    {

     _coinsSerice = new CoinsService();
    }

    [HttpGet]
    public ActionResult<List<string>> Get()
    {
      List<String> result = _coinsSerice.getLists();
      if (result == null) { return Unauthorized(); }
      return (result);
    }

    [HttpGet("GetByid")]
        public ActionResult<CoinDTO> GetById(string id)
        {
            if (id == null) { return Unauthorized(); }
            CoinDTO result = _coinsSerice.getID(id);
            if (result == null) { return Unauthorized(); }
            return (result);
        }

    [HttpGet("{id}/file/{num}")]
    public ActionResult<CoinDTO> GetId(string id,int num)
    {
      if (id == null) { return Unauthorized(); }
      CoinDTO result = _coinsSerice.getID(id);
      if (result == null) { return Unauthorized(); }
      return (result);
    }

    [HttpPost()]
    public ActionResult<bool > Post([FromBody]CoinDTO dto )
    {
      
     return _coinsSerice.add(dto);
     
    }
  }
}
