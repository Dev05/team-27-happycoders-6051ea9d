using System.Drawing;

namespace levelup
{
    public class Map
    {


        private int MinX;
        private int MinY;
        private int MaxX;
        private int MaxY;

    public Map(int minX, int minY, int maxX, int maxY)
    {
            this.MinX=minX;
            this.MinY=minY;
            this.MaxX=maxX;
            this.MaxY=maxY;
    }    

    public bool Validate(Position position)
    {
        if (position.X < MinX) return false;
        if (position.Y < MinY) return false;

        if (position.X > MaxX) return false;
        if (position.Y > MaxY) return false;

        return true;
    }    
    
    public Position CalculatePosition(Position position, DIRECTION d)
    {
        Position newPosition =position;
        bool validPosition = false;
            
          if (d == DIRECTION.NORTH)
            {
                newPosition.Y = position.Y +1;
            }
            else if (d == DIRECTION.SOUTH)
            {
                newPosition.Y = position.Y - 1;
            }
            else if (d == DIRECTION.WEST) {
                newPosition.X = position.X -1 ;
            }
            else if (d == DIRECTION.EAST) {
                newPosition.X = position.X + 1;
            }
        /* switch(direction)
        {
            case GameController.DIRECTION.NORTH: 
                newPosition.Y++;
                break;
            case GameController.DIRECTION.SOUTH: 
                newPosition.Y--;
                break;
            case GameController.DIRECTION.WEST: 
                 newPosition.X--;
                 break;
            case GameController.DIRECTION.EAST: 
                newPosition.X++;
                break;
            default:
                throw new System.Exception("No Direction Found");
            */
                validPosition = Validate(newPosition);
        //}
        return (validPosition ? newPosition : position); 
    }


    }
}