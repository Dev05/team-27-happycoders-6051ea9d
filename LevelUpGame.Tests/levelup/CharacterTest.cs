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
            public void getCharacterPositionTest(){
            var testObj= new Character("abc");
            Position pos= testObj.GetPosition();            
            Assert.AreEqual(pos.X,5);
           Assert.AreEqual(pos.Y,5);
         }

         [Test]
            public void setCharacterPositionTest(){
            var testObj= new Character("abc");
            testObj.SetPosition(0,0);
            Position pos= testObj.GetPosition();            
            Assert.AreEqual(pos.X,0);
           Assert.AreEqual(pos.Y,0);
         }

        
		
         [Test]
         public void MoveNorth(){
            var testObj = new Character("Terminator");
            //Default position is 5, 5
			Position newPosition= new Position(5,6);
            Position nextPosition = testObj.Move(GameController.DIRECTION.NORTH);
            Assert.IsEqual(newPosition.X,nextPosition.X);
			Assert.IsEqual(newPosition.Y,nextPosition.Y);
         }
		 
         [Test]
         public void MoveSouth(){
            var testObj = new Character("Terminator");
            //Default position is 5, 5
			Position newPosition= new Position(5,4);
            Position nextPosition = testObj.Move(GameController.DIRECTION.SOUTH);
            Assert.IsEqual(newPosition.X,nextPosition.X);
			Assert.IsEqual(newPosition.Y,nextPosition.Y);
         }

        [Test]
         public void MoveWest(){
           var testObj = new Character("Terminator");
            //Default position is 5, 5
			Position newPosition= new Position(4,5);
            Position newPosition = testObj.Move(GameController.DIRECTION.WEST);
            Assert.IsEqual(newPosition.X,nextPosition.X);
			Assert.IsEqual(newPosition.Y,nextPosition.Y);
         }

         [Test]
         public void MoveEast(){
           var testObj = new Character("Terminator");
            //Default position is 5, 5
			Position newPosition= new Position(6,5);
            Position newPosition = testObj.Move(GameController.DIRECTION.EAST);
             Assert.IsEqual(newPosition.X,nextPosition.X);
			Assert.IsEqual(newPosition.Y,nextPosition.Y);
         }

         
         
    }
}