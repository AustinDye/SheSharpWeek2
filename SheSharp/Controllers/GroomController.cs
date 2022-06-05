using System;
using Microsoft.AspNetCore.Mvc;
using SheSharp.Models;
using SheSharp.Services;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;


namespace SheSharp.Controllers
{
 [ApiController]
[Route("api/[controller]")]

public class GroomController : ControllerBase
{

 private readonly GroomService _groomServ;

public GroomController(GroomService groomServ)
  {
    _groomServ = groomServ;
  }

  [HttpPost]
  [Authorize]
  public async Task<ActionResult<Groom>> Create([FromBody] Groom groomData)
  {
   try
   {
    Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
    groomData.CreatorId = userInfo.Id;
    Groom groom = _groomServ.Create(groomData);
    groom.Creator = userInfo;
    return Ok(groom);
   }
   catch (Exception e)
   {
    return BadRequest(e.Message);
   }

  }

  [HttpGet]
  public ActionResult<List<Groom>> Get()
  {
   try
   {
    List<Groom> groom = _groomServ.Get();
    return Ok(groom);
   }
   catch (Exception e)
   {
    return BadRequest(e.Message);
   }
  }


}
 
}



