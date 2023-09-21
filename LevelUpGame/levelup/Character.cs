

namespace levelup
{
    public class Character{

    public String Name{get;set;}
    public Position currentPosition {get;set;}
    public Position newPosition {get;set;}

    private Position GetPosition(){
        return currentPosition;
    }

    private void SetPosition(Position position){
        currentPosition = position;
    }

    public Character(String name){
        Name=name??"Character";
        currentPosition.X = 5;
        currentPosition.Y = 5;
    }

    public Position Move(GameController.DIRECTION direction){
        newPosition = currentPosition;
        bool validPosition = false;
        CASE direction:
            GameController.DIRECTION.NORTH: 
                validPosition = Map.Validate(newPosition.Y++); break;
            GameController.DIRECTION.SOUTH: 
                validPosition = Map.Validate(newPosition.Y--); break;
            GameController.DIRECTION.WEST: 
                validPosition = Map.Validate(newPosition.X--); break;
            GameController.DIRECTION.EAST: 
                validPosition = Map.Validate(newPosition.X++); break;


        return (validPosition ? newPosition : currentPosition);
    }

    }
}