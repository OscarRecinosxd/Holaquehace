namespace ProyectoFinal
{
    public abstract class Shape
    {
        protected int x;
        protected int y;
        protected int movementX;

        protected Shape(int x, int y, int movementX)
        {
            this.x = x;
            this.y = y;
            this.movementX = movementX;
        }
        
    
    }
}