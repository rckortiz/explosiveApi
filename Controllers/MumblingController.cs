using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace explosiveapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> Mumble(string s)
    {
      return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
  }
}




