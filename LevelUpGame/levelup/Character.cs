

namespace levelup
{
    public class Character{

    public String Name{get;set;}
    private String DefaultName="Character";
    public Position currentPosition {get;set;}
    private Map map;


    public Character(String name){ 
        Name=name??DefaultName; 
    }

    public Character(){ 
        Name=DefaultName; 
    }    
    
    public Position GetPosition(){
        return currentPosition;
    }

    public String GetName(){
        return Name;
    }


    }
}