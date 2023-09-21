using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class MapTest
    {
        private Map? testObj;

  
        public void InitMap(int minX, int minY, int maxX, int maxY)
        {
             testObj = new Map(minX, minY, maxX, maxY);
        }

        [Test]
        public void ValidateInvalidCoordinates()
        {

            InitMap(0,0,9,9);
            bool IsValidCoordinate = testObj.Validate(10,0);
            Assert.IsFalse(IsValidCoordinate);
        }

        [Test]
        public void ValidateValidCoordinates()
        {
            InitMap(0,0,9,9);
            bool IsValidCoordinate = testObj.Validate(5,5);
            Assert.IsTrue(IsValidCoordinate);
        }
    }
}