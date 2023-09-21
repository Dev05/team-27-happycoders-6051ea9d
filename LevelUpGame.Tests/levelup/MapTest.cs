using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class MapTest
    {
        private Map? testObj;

  
        [SetUp]
        public void InitMap(int minX, int minY, int maxX, int maxY)
        {
             testObj = new Map(MinX, MinY, MaxX, MaxY);
        }

        [Test]
        public bool ValidateInvalidCoordinates()
        {

            InitMap(0,0,9,9);
            bool IsValidCoordinate = testObj.Validate(10,0);
            Assert.IsFalse(IsValidCoordinate);
        }

        [Test]
        public bool ValidateValidCoordinates()
        {
            InitMap(0,0,9,9);
            bool IsValidCoordinate = testObj.Validate(5,5);
            Assert.IsTrue(IsValidCoordinate);
        }
    }
}