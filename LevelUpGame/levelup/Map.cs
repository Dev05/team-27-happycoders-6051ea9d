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

    public bool Validate(int xCoordinate, int yCoordinate)
    {
        if (xCoordinate < MinX) return false;
        if (yCoordinate < MinY) return false;

        if (xCoordinate > MaxX) return false;
        if (yCoordinate > MaxY) return false;

        return true;
    }    



    }
}