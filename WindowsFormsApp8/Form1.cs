using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 20;//рядов 
            int y = 20;//столбцов
            int r = 30;//расстояние
            for (int i = 0; i < x * y; i++)
            {
                Button b = new Button();
                b.Location = new Point((i % x + 1) * r, (i / y + 1) * r);
                b.Size = new Size(30, 30);
                Controls.Add(b);
            }
        }
    }
}
