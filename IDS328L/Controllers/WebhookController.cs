﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IDS328L.DTO;
using IDS328L.Services;
using System.Text.Json;

namespace CORE_Api_Pymes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        [HttpPost]
        public ActionResult ReceiveWebhook([FromBody] object payload)
        {
            Console.WriteLine(payload);
            // Comentario inútil para hacer un push innecesario
            return Ok();
        }
    }

    
}
