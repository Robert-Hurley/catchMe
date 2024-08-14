using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Random ranNum = new Random();
            Point newPoint = new Point();
            int xLoc, yLoc;

            xLoc = ranNum.Next(Screen.PrimaryScreen.Bounds.Width-100);
            yLoc = ranNum.Next(Screen.PrimaryScreen.Bounds.Height-200);

            newPoint.X = xLoc;
            newPoint.Y = yLoc;

            this.Location = newPoint;
        }
    }
}
