using NUnit.Framework;
using levelup;

namespace levelup
{

    [TestFixture]
    public class CharacterTest{

         [Test]
         public void SetCharacterNameTest(){
            var testObj= new Character("Terminator");
            Assert.IsNotNull(testObj.Name);
            Assert.AreEqual(testObj.Name,"Terminator");
         }

          [Test]
            public void SetCharacterNameNullTest(){
            var testObj= new Character(null);
            Assert.IsNotNull(testObj.Name);
            Assert.AreEqual(testObj.Name,"Character");
         }

          [Test]
            public void SetCharacterNameNotDefaultTest(){
            var testObj= new Character("abc");
            Assert.IsNotNull(testObj.Name);
            Assert.AreNotEqual(testObj.Name,"Character");
         }

          [Test]
            public void SetCharacterNameDefaultTest(){
            var testObj= new Character();
            Assert.IsNotNull(testObj.Name);
            Assert.AreEqual(testObj.Name,"Character");
         }

         [Test]
            public void GetCharacterNameTest(){
            var testObj= new Character();           
            Assert.AreEqual(testObj.GetName(),"Character");
         }        

         
          [Test]
            public void EnterMapTest(){
            var testObj= new Character();   
            Map map= new Map(0,0,4,4);
            testObj.EnterMap(map);        
            Assert.IsNotNull(testObj.currentMap);
         }
         
    }
}