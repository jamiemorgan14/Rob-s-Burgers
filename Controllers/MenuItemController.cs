using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Robs_Burgers.Database;
using Robs_Burgers.Models;

namespace Robs_Burgers.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MenuItemController : ControllerBase
  {
    List<MenuItem> Menu = Data.Menu;

    // GET api/values
    [HttpGet]
    public ActionResult<List<MenuItem>> Get()
    {
      return Menu;
    }

    // GET api/values/5
    [HttpGet("{number}")]
    public ActionResult<MenuItem> Get(int number)
    {
      MenuItem found = Menu.Find(i => i.Number == number);
      if (found != null)
      {
        return found;
      }
      return NotFound("Not found");
    }

    // POST api/values
    [HttpPost]
    public ActionResult<List<MenuItem>> Post([FromBody] MenuItem value)
    {
      Menu.Add(value);
      return Menu;
    }

    // PUT api/values/5
    [HttpPut("{number}")]
    public ActionResult<MenuItem> Put(int number, [FromBody] MenuItem newData)
    {
      MenuItem oldData = Menu.Find(i => i.Number == number);
      if (oldData == null) { return BadRequest(); }
      Menu.Remove(oldData);
      Menu.Add(newData);
      return newData;
    }

    // DELETE api/values/5
    [HttpDelete("{number}")]
    public ActionResult Delete(int number)
    {
      MenuItem oldData = Menu.Find(i => i.Number == number);
      if (oldData == null) { return BadRequest(); }
      Menu.Remove(oldData);
      return Ok();
    }
  }
}
