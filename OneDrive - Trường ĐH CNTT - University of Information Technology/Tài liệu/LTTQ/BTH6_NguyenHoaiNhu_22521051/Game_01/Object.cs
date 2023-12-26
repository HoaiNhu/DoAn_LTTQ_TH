using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game_01
{
    public class Object
    {
        protected Bitmap item;
        protected double x;
        protected double y;
        protected int width;
        protected int height;

        public Object()
        { }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }

        public void DrawObject(Graphics e)
        {
            e.DrawImage(item, (float)x, (float)y, width, height);           
        }

        //Kiểm tra Ball có chạm vào Basket hay không
        public bool IntersertCheck(Object other)
        {
            bool isTouchingTop =( y + height / 2) >= other.y; // điểm chạm của Ball và Basket ở trên, nếu ball trùng vs y của basket thì 2 vật chạm nhau 

            bool isIntersertingX = (x + width / 2) <= (other.x + other.width) && (x +  width / 2) >= other.x; //chạm ở x /trong vùng giao thoa của hai đối tượng

            return isTouchingTop && isIntersertingX;
        }
    }
}
