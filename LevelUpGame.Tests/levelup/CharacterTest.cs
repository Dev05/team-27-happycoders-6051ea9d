using NUnit.Framework;
using levelup;

namespace levelup
{

    [TestFixture]
    public class CharacterTest{

         [Test]
         public void SetCharacterName(){
            var testObj= new Character("Terminator");
            Assert.IsNotNull(testObj.Name);
            Assert.AreEqual(testObj.Name,"Terminator");
         }

          [Test]
            public void SetCharacterNameNull(){
            var testObj= new Character(null);
            Assert.IsNotNull(testObj.Name);
            Assert.AreEqual(testObj.Name,"Character");
         }

          [Test]
            public void SetCharacterNameNotDefault(){
            var testObj= new Character("abc");
            Assert.IsNotNull(testObj.Name);
            Assert.AreNotEqual(testObj.Name,"Character");
         }


         [Test]
         public void MoveNorth(){
            var testObj = new Character("Terminator");
            //Default position is 5, 5
            Position testPos= new Position(5,6);
            Position newPosition = testObj.Move(GameController.DIRECTION.NORTH);
            Assert.AreEqual(newPosition.X, testPos.X);
            Assert.AreEqual(newPosition.Y, testPos.Y);
         }

         [Test]
         public void MoveSouth(){
            var testObj = new Character("Terminator");
            //Default position is 5, 5
            Position newPosition = testObj.Move(GameController.DIRECTION.SOUTH);
            Assert.IsTrue(validMove);
         }

        [Test]
         public void MoveWest(){
           var testObj = new Character("Terminator");
            //Default position is 5, 5
            Position newPosition = testObj.Move(GameController.DIRECTION.WEST);
            Assert.IsTrue(validMove);
         }

         [Test]
         public void MoveEast(){
           var testObj = new Character("Terminator");
            //Default position is 5, 5
            Position newPosition = testObj.Move(GameController.DIRECTION.EAST);
            Assert.IsTrue(validMove);
         }
    }
}