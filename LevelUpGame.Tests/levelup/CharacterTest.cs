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
         public void MoveUp(){
            var testObj = new Character("Terminator");
            //Default position is 5, 5
            bool validMove = testObj.Move("UP");
            Assert.IsTrue(validMove);
         }

         [Test]
         public void MoveDown(){
            var testObj = new Character("Terminator");
            //Default position is 5, 5
            bool validMove = testObj.Move("DOWN");
            Assert.IsTrue(validMove);
         }

        [Test]
         public void MoveRight(){
           var testObj = new Character("Terminator");
            //Default position is 5, 5
            bool validMove = testObj.Move("RIGHT");
            Assert.IsTrue(validMove);
         }

         [Test]
         public void MoveLeft(){
           var testObj = new Character("Terminator");
            //Default position is 5, 5
            bool validMove = testObj.Move("LEFT");
            Assert.IsTrue(validMove);
         }
    }
}