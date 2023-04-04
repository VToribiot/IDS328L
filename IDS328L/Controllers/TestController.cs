using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IDS328L.DTO;
using IDS328L.Services;

namespace CORE_Api_Pymes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public ActionResult ReceiveWebhook([FromBody] object payload)
        {
            // Process the payload data as needed
            // Here, we're just logging it to the console
            Console.WriteLine(payload);

            // Send a response to indicate that the payload was received successfully
            return Ok();
        }
    }

    
}
