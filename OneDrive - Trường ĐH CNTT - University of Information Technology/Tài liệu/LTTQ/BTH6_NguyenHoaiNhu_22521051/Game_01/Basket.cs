using System;
using System.Collections.Generic;
using System.Drawing;
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
            height = 100;
            x = (clientWidth - width)/2;
            y = (clientHeight - height); // định vị trí chiều cao của basket
        }

        //xử ký di chuyển của basket
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
