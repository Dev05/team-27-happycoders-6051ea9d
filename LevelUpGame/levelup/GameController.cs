using System.Drawing;

namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
        private Character terminator;
        private Map map=new Map(0,0,9,9);
        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            Position currentPosition,
            int moveCount
            );

        // TODO: Ensure this AND CLI commands match domain model

        public GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            //Set current position to a nonsense place until you figure out who should initialize
            status.currentPosition = new Position(5,5);
            //TODO: Write a failing unit test that will force you to set this to the right number
            status.moveCount = 0;
        }

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(String name)
        {
           terminator =new Character(name);
           this.status.characterName=name;
        }

        public void StartGame()
        {
            // TODO: Implement startGame - Should probably create positions and put the character on one
            // TODO: Should also update the game status?         
            terminator.currentPosition=this.status.currentPosition;           
            terminator.currentMap=map;
            terminator.EnterMap(map);
        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
            terminator.Move(directionToMove);
            this.status.currentPosition = terminator.GetPosition();
             this.status.moveCount=map.TotalMoveCount;
        }

        public void SetCharacterPosition(Position coordinates)
        {
            //TODO: IMPLEMENT THIS TO SET CHARACTERS CURRENT POSITION -- exists to be testable
        }

        public void SetCurrentMoveCount(int moveCount)
        {
            //TODO: IMPLEMENT THIS TO SET CURRENT MOVE COUNT -- exists to be testable
            this.status.moveCount= map.TotalMoveCount;
        }

        public int GetTotalPositions()
        {
            //TODO: IMPLEMENT THIS TO GET THE TOTAL POSITIONS FROM THE MAP -- exists to be testable
            
            return map.TotalMoveCount;
        }


    }

        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }
}