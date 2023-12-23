using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_01
{
    public class Ball : Object
    {
        bool wasOut;

        public Ball(int x)
        {
            this.x = x;
            this.y = -40;
            item = Properties.Resources.Ball;
            item = Properties.Resources.Ball_2;
            width = 100;
            height = 100;
            wasOut = false;
        }

        public void Drop(double speed)
        {
            y += speed;
        }

        public bool IsOut(int maxheight)
        {
            if (y + height > maxheight)
            {
                return true;
            }
            return false;
        }

        public bool checkWasOut()
        {
            return wasOut;
        }

        public void setWasOut()
        {
            wasOut = true;
        }
    }
}
