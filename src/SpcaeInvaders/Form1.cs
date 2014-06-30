using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpcaeInvaders
{
    public partial class Form1 : Form
    {
        Graphics space;
        private bool left;
        private bool right;
        private bool up;
        private bool down;
        public int score = 0;

        readonly Random rand = new Random();

        public Ship ship = new Ship();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            space = e.Graphics;
            ship.drawShip(space);
        }

    }
}
