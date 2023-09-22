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
            public void SetCharacterNameEmptyTest(){
            var testObj= new Character("");
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

          [Test]
            public void GetPositionTest(){
            var testObj= new Character();
            var pos=testObj.GetPosition();        
            Assert.AreEqual(pos.X,5);
            Assert.AreEqual(pos.Y,5);
         }

          [Test]
            public void MoveNorthTest(){
            var testObj= new Character();        
            testObj.Move(DIRECTION.NORTH);   
            Position currPos= testObj.GetPosition();
            Assert.AreEqual(currPos.X,5);
             Assert.AreEqual(currPos.Y,6);
         }     

          [Test]
            public void MoveSouthhTest(){
            var testObj= new Character();        
            testObj.Move(DIRECTION.SOUTH);   
            Position currPos= testObj.GetPosition();
            Assert.AreEqual(currPos.X,5);
             Assert.AreEqual(currPos.Y,4);
         }     

          [Test]
            public void MoveEastTest(){
            var testObj= new Character();        
            testObj.Move(DIRECTION.EAST);   
            Position currPos= testObj.GetPosition();
            Assert.AreEqual(currPos.X,6);
             Assert.AreEqual(currPos.Y,5);
         }     

          [Test]
            public void MoveWestTest(){
            var testObj= new Character();        
            testObj.Move(DIRECTION.WEST);   
            Position currPos= testObj.GetPosition();
            Assert.AreEqual(currPos.X,4);
             Assert.AreEqual(currPos.Y,5);
         }     
         
    }
}