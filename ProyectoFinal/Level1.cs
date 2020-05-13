using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Level1 : Form
    {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        public Level1()
        {
            InitializeComponent();

        }

        private void Push(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
             case (Keys.Right):
                 rectangle.Moving(true,this.Width);
                 break;
             case (Keys.Left):
                 rectangle.Moving(false,this.Width);
                 break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            BufferedGraphicsContext space = BufferedGraphicsManager.Current;
            BufferedGraphics buffer = space.Allocate(g, this.ClientRectangle);
            buffer.Graphics.Clear(Color.Black);
            circle.Show(buffer.Graphics);
            rectangle.Show(buffer.Graphics);
            circle.Moving(this.Width,rectangle.Y,rectangle.X,rectangle.getTotal());
            buffer.Render(g);
            
        }
    }
}