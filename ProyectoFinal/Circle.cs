using System;
using System.Drawing;
using System.Runtime.Remoting.Proxies;

namespace ProyectoFinal
{
    public class Circle
    {
        
        private int movementY;
        private int diameter;
        private int lifes;


        public Circle(int x, int y, int movementX, int movementY, int diameter)
        {
            Random rnd = new Random();
            this.x = rnd.Next(1, 200);
            this.y = 1 ;
            this.movementX = 20;
            this.movementY = 20;
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
                Random rnd = new Random();
                x = rnd.Next(1, 200);
                y = 1;
                lifes--;
            }
        }
    }
}