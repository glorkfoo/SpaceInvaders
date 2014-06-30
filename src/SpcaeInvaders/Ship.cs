using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcaeInvaders
{
    public class Ship
    {
        public Rectangle[] ShipRec;
        private readonly SolidBrush Brush;
        private readonly int x, y, width, height;

        public Ship()
        {
            ShipRec = new Rectangle[17];
            Brush = new SolidBrush(Color.Black);

            x = 50;
            y = 250;
            width = 5;
            height = 5;

            for (int i = 0; i < 3; i++)
            {
                ShipRec[i] = new Rectangle(x, y, width, height);
                x -= 5;
            }

            x = 50;

            for (int i = 4; i < 7; i++)
            {
                ShipRec[i] = new Rectangle(x, y, width, height);
                x += 5;
            }

            x = 50;

            for (int i = 8; i < 11; i++)
            {
                ShipRec[i] = new Rectangle(x, y, width, height);
                y -= 5;
            }

            y = 250;

            for (int i = 12; i < 14; i++)
            {
                ShipRec[i] = new Rectangle(x, y, width, height);
                x -= 5;
                y -= 5;
            }

            x = 50;
            y = 250;

            for (int i = 15; i < 17; i++)
            {
                ShipRec[i] = new Rectangle(x, y, width, height);
                x += 5;
                y -= 5;
            }

            x = 50;
            y = 250;

        }

        public void drawShip(Graphics g)
        {
            foreach (Rectangle rec in ShipRec)
            {
                g.FillRectangle(Brush, rec);
            }
        }

        public void moveLeft()
        {
            for (int i = 0; i < ShipRec.Length; i++)
            {
                ShipRec[i].X -= 5;
            }
        }

        public void moveRight()
        {
            for (int i = 0; i < ShipRec.Length; i++)
            {
                ShipRec[i].X += 5;
            }
        }

        public void moveUp()
        {
            for (int i = 0; i < ShipRec.Length; i++)
            {
                ShipRec[i].Y -= 5;
            }
        }

        public void moveDown()
        {
            for (int i = 0; i < ShipRec.Length; i++)
            {
                ShipRec[i].Y += 5;
            }
        }

        public void Shoot()
        {
            
        }

    }
}
