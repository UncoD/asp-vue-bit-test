namespace AspVueBit.Data
{
    public class CameraParameters
    {
        public int Id { get; set; }
        public double CameraHeight { get; set; }
        public double ObjectHeight { get; set; }
        public double DistanceToObject { get; set; }
        public double CameraAngle { get; set; }

        public CameraParameters(double cameraHeight, double objectHeight, double distanceToObject, double cameraAngle)
        {
            CameraHeight = cameraHeight;
            ObjectHeight = objectHeight;
            DistanceToObject = distanceToObject;
            CameraAngle = cameraAngle;
        }
    }
}