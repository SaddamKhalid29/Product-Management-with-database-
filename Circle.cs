using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace DrawingAppOOP
{
    internal class Circle : Shape
    {
        private int radius;

        private int outlineWidth;

        private Color outlinecolor;

        public int Radius
        {

            get { 
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public int OutlineWidth
        {
            get
            {
                return outlineWidth;
            }
            set
            {
                outlineWidth=value;
            }
        }

        public Color OutlineColor
        {
            get
            {
                return outlinecolor;
            }
            set
            {
                outlinecolor=value;
            }
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(OutlineColor,OutlineWidth);
            g.DrawEllipse(pen, X, Y, Radius, Radius);
        }
    }
}
