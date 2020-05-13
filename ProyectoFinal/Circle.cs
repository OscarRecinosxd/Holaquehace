using System;
using System.Drawing;
using System.Runtime.Remoting.Proxies;

namespace ProyectoFinal 
{
    public class Circle : Shape
    {
        
        private int movementY;
        private int diameter;
        private int lifes;
        
        
        //int x, int y, int movementX, int movementY, int diameter
        public Circle() : base(295,1,5)
        {
            this.movementY = 5;
            this.diameter = 15;
            this.lifes = 3;
        }

        public void Show(Graphics g)
        {
            //SolidBrush Color = new SolidBrush(System.Drawing.Color.Lime);   
            g.FillEllipse(Brushes.Chartreuse , x, y,diameter,diameter);
        }

        public void Moving(int maxinx, int Yposition, int x1 ,int x2  )
        {
            x += movementX;
            y += movementY;
            if (x <= 0 || x + diameter >= maxinx)
            {
                movementX *= -1;
            }

            else if (y <= 0 ||( y + diameter >= Yposition && x > x1 && x < x2))
            {
                movementY *= -1;
            }

            else if (y > Yposition && lifes>0)
            {
                x = 295;
                y = 680;
                movementY = 5;
                movementX = 5;
                lifes--;
            }
        }
    }
}