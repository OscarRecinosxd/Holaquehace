using System.Drawing;

namespace ProyectoFinal
{
    public class Rectangle 
    {
        private int width;
        private int height;

        public int X => x;

        public int Y => y;

        public int getTotal()
        {
            return x + width;
            
        }
        

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = 275;
            this.y = 75;
            this.movementX = 30;
            this.width = 50;
            this.height = 30;
            
        }
        
        public void Show(Graphics g)
        {
            //SolidBrush Color = new SolidBrush(System.Drawing.Color.Lime);   
            g.FillRectangle(Brushes.Sienna , x, y,width,height);
        }

        public void Moving(bool direction, int maxFormx)
        {
            if (x + width < maxFormx && direction == true)
            {
                x += movementX;
            }
            else if (x > 0 && direction == false)
            {
                x -= movementX;
            }
        }
    }
}