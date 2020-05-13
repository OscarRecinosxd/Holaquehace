using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Jugar : Form
    {
        public Jugar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Level1 form = new Level1();
            form.ShowDialog();
        }
    }
}