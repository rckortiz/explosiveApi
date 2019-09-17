using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace explosiveapi.controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("{s}")]
    public ActionResult<string> explosion(string s)
    {
      return string.Join("", s.Select(c => new String(c, int.Parse(c.ToString()))));
    }
  }
}