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
            Position p=new Position(10,0);
            bool IsValidCoordinate = testObj.Validate(p);
            Assert.IsFalse(IsValidCoordinate);
        }

        [Test]
        public void ValidateValidCoordinates()
        {
            InitMap(0,0,9,9);
            Position p=new Position(5,5);
            bool IsValidCoordinate = testObj.Validate(p);
            Assert.IsTrue(IsValidCoordinate);
        }
    }
}