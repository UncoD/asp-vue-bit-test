using AspVueBit.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspVueBit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CameraAngleCalculatorController : ControllerBase
    {
        [HttpGet]
        public double Get([FromQuery] double distanceToObject, [FromQuery] double cameraHeight, [FromQuery] double objectHeight)
        {
            var calculator = new CameraAngleCalculator();
            return calculator.CalculateAngleDegrees(distanceToObject, cameraHeight, objectHeight);
        }
    }
}