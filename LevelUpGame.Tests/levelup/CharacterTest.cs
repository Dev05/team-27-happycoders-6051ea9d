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
            public void SetCharacterNameDefault(){
            var testObj= new Character();
            Assert.IsNotNull(testObj.Name);
            Assert.AreEqual(testObj.Name,"Character");
         }

             [Test]
            public void GetCharacterName(){
            var testObj= new Character();           
            Assert.AreEqual(testObj.GetName(),"Character");
         }
         
         
    }
}