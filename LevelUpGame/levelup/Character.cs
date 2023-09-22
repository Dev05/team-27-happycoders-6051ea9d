

namespace levelup
{
    public class Character{

    public String Name{get;set;}
    private String DefaultName="Character";
    public Position currentPosition {get;set;}
    public Map? currentMap;


    public Character(String name){ 
        Name=(name==null || name.Length==0)?DefaultName:name; 
        currentPosition= new Position(5,5);
    }

    public Character(){ 
        Name=DefaultName; 
        currentPosition= new Position(5,5);
    }    
    
    public Position GetPosition(){
        return currentPosition;
    }

    public String GetName(){
        return Name;
    }

    public void EnterMap(Map map){
        currentMap=map;
    }

    public void Move(DIRECTION dir){
        currentPosition=currentMap.CalculatePosition(currentPosition,dir);
    }

    }
}