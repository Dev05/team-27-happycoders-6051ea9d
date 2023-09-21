

namespace levelup
{
    public class Character{

    public String Name{get;set;}
    public Position currentPosition {get;set;}

    private Position GetPosition(){
        return currentPosition;
    }

    private void SetPosition(Position position){
        currentPosition = position;
    }

    public Character(String name){
        Name=name??"Character";
        currentPosition.x = 5;
        currentPosition.y = 5;
    }

    public bool Move(String direction){
        
        CASE direction:
            "UP": currentPosition.y++; break;
            "DOWN": currentPosition.y--; break;
            "LEFT": currentPosition.x--; break;
            "RIGHT": currentPosition.x++; break;
    }

    }
}