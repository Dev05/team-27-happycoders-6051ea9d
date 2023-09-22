

namespace levelup
{
    public class Character{

    public String Name{get;set;}
    public Position currentPosition {get;set;}
   
    public Position GetPosition(){
        return currentPosition;
    }

    public void SetPosition(Position position){
        currentPosition = position;
    }

    public Character(String name){
        Name=name??"Character";
        currentPosition.X = 5;
        currentPosition.Y = 5;
    }

    public Position Move(GameController.DIRECTION direction){
       Position newPosition = currentPosition;
        bool validPosition = false;
        switch(direction){
            case GameController.DIRECTION.NORTH: 
                validPosition = Map.Validate(newPosition.Y++);
                 break;
            case GameController.DIRECTION.SOUTH: 
                validPosition = Map.Validate(newPosition.Y--); 
                break;
            case GameController.DIRECTION.WEST: 
                validPosition = Map.Validate(newPosition.X--);
                 break;
            case GameController.DIRECTION.EAST: 
                validPosition = Map.Validate(newPosition.X++); 
                break;

        }
        return (validPosition ? newPosition : currentPosition);
    }

    }
}