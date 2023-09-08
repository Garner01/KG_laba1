using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawRectangle(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 4);
            Graphics g = canvas.CreateGraphics();
            int width = 400;
            int height = 300;
            g.DrawRectangle(pen, new Rectangle((canvas.Size.Width / 2) - width / 2, 50, width, height));
            g.Dispose();
        }
    }
}
