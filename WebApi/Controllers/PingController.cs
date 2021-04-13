using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class PingController : ControllerBase
    {
        [HttpGet("api/ping")]
        public ActionResult<string> Ping()
        {
            return $"{DateTimeOffset.UtcNow:u}";
        }
    }
}