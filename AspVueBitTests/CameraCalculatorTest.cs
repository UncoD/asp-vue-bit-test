using AspVueBit.Models;
using NUnit.Framework;

namespace AspVueBitTests
{
    [TestFixture]
    public class CameraCalculatorTest
    {
        private int objectHeight = 160;

        [Test]
        public void ZeroDistanceAboveObject()
        {
            var calculator = new CameraAngleCalculator();
            var distance = 0;
            var cameraHeight = objectHeight + 200;

            var angle = calculator.CalculateAngleDegrees(distance, cameraHeight, objectHeight);

            Assert.AreEqual(90, angle);
        }

        [Test]
        public void ZeroDistanceUnderObject()
        {
            var calculator = new CameraAngleCalculator();
            var distance = 0;
            var cameraHeight = objectHeight - 200;

            var angle = calculator.CalculateAngleDegrees(distance, cameraHeight, objectHeight);

            Assert.AreEqual(-90, angle);
        }

        [Test]
        public void CameraOnObjectHeight()
        {
            var calculator = new CameraAngleCalculator();
            var distance = 200;
            var cameraHeight = objectHeight;

            var angle = calculator.CalculateAngleDegrees(distance, cameraHeight, objectHeight);

            Assert.AreEqual(0, angle);
        }

        [Test]
        public void ZeroDistanceOnObjectHeight()
        {
            var calculator = new CameraAngleCalculator();
            var distance = 0;
            var cameraHeight = objectHeight;

            var angle = calculator.CalculateAngleDegrees(distance, cameraHeight, objectHeight);

            Assert.AreEqual(0, angle);
        }


        [Test]
        public void MaxDistanceAndHeight()
        {
            var calculator = new CameraAngleCalculator();
            var distance = int.MaxValue;
            var cameraHeight = int.MaxValue;

            var angle = calculator.CalculateAngleDegrees(distance, cameraHeight, 0);

            Assert.AreEqual(45, angle);
        }
    }
}