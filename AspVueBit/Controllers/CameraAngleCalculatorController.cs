using AspVueBit.Data;
using AspVueBit.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspVueBit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CameraAngleCalculatorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CameraAngleCalculatorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public double Get([FromQuery] double distanceToObject, [FromQuery] double cameraHeight, [FromQuery] double objectHeight)
        {
            var calculator = new CameraAngleCalculator();
            var angle = calculator.CalculateAngleDegrees(distanceToObject, cameraHeight, objectHeight);

            _context.CameraParameters.Add(new CameraParameters(cameraHeight, objectHeight, distanceToObject, angle));
            _context.SaveChanges();

            return angle;
        }
    }
}