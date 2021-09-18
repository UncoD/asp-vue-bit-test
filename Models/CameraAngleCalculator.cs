using System;

namespace AspVueBit.Models
{
    public class CameraAngleCalculator
    {
        public double CalculateAngleDegrees(double distanceToObject, double cameraHeight, double objectHeight)
        {
            var heightAboveHuman = cameraHeight - objectHeight;
            var angle = Math.Atan2(heightAboveHuman, distanceToObject);
            return angle * 180 / Math.PI;
        }
    }
}