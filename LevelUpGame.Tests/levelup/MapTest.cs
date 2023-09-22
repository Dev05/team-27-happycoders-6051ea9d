using NUnit.Framework;
using levelup;
using System.Diagnostics;

namespace levelup
{
    [TestFixture]
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
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

        [Test]
        public void CalculatePositionTest()
        {
            InitMap(0,0,9,9);
            Position p=new Position(5,5);
            Position ExpectedPosition = new Position(5,6);
            Position newPosition = testObj.CalculatePosition(p, DIRECTION.NORTH);
            Assert.AreEqual(newPosition.X,ExpectedPosition.X);
            Assert.AreEqual(newPosition.Y,ExpectedPosition.Y);
            
        }

                [Test]
        public void CalculateTotalMovesTest()
        {
            InitMap(0,0,9,9);
            testObj.TotalMoveCount =5;
            Position p=new Position(5,5);
            Position ExpectedPosition = new Position(5,6);
            Position newPosition = testObj.CalculatePosition(p, DIRECTION.NORTH);
            Assert.AreEqual(newPosition.X,ExpectedPosition.X);
            Assert.AreEqual(newPosition.Y,ExpectedPosition.Y);
            Assert.AreEqual(testObj.TotalMoveCount,6);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}