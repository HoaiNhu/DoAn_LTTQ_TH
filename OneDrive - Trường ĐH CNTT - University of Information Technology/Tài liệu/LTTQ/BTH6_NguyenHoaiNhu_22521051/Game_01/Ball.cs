using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Game_01
{
    public class Ball : Object
    {
        bool wasOut;

        public Ball(int x, int ran)
        {
            this.x = x;
            this.y = -40;
            
            if(ran == 0)
            {
                item = Properties.Resources.Ball_2;
            }    
            else   if(ran == 1)          
            {
                item = Properties.Resources.Ball;
            }    
            else if(ran == 2)
            {
                item = Properties.Resources.Ball_3;
            }    

            width = 100;
            height = 100;
            wasOut = false;
        }

        public void Drop(double speed)
        {
            y += speed;
        }

        
        //Kiểm tra đã ra khỏi screen chưa
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
