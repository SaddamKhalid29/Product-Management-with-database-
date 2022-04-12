using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingAppOOP
{
    internal class Shape
    {

        public int X;
        public int Y;

        public virtual void Draw(Graphics g)
        {

        }
        public virtual bool isRect()
        {
            return false;
        }
    }
}
