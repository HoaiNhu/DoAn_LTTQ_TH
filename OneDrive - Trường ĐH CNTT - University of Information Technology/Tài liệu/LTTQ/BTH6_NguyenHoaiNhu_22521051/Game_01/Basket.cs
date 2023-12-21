using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_01
{
    public class Basket : Object
    {
        public Basket(int clientWidth, int clientHeight)
        {
            item = Properties.Resources.Basket;
            width = 160;
            height = 40;
            x = (clientWidth - width) / 2;
            y = (clientHeight - height) / 2;
        }

        public void move(bool IsLeft, int maxwidth, double speed)
        {
            if (IsLeft)
            {
                x -= speed;
                if (x < 0) x = 0;
            }
            else
            {
                x += speed;
                if (x + width > maxwidth)
                {
                    x = maxwidth - width;
                }
            }
        }

    }
}
