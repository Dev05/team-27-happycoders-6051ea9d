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



    }
}