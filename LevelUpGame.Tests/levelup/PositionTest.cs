using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;

    [Test] 
        public void TestPosition()
        {
            int x = 0;
            int y = 9;

            testObj = new Position(x, y);
            Assert.AreEqual(testObj.X,x);
            Assert.AreEqual(testObj.Y,y);
        }

    }
}