﻿using Microsoft.AspNetCore.Mvc;

namespace se100_cs.Controllers
{
    [Route("api/[controller]")]
    public class DashBoardController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public ActionResult getStats()
        {
            return Ok(Program.api_dashboard.getStats());
        }
    }
}
