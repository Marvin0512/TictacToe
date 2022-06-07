using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomControl1 : Control
    {
        public CustomControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;

            RectangleF[] rects =
            {
                new Regta
            }


            //Rectangle frameRectangle = new Rectangle(0, 0, 30, 30);
            //g.DrawRectangles(Pens.Black, frameRectangle[],rects);

        }
    }
}
//https://docs.microsoft.com/de-de/dotnet/api/system.drawing.graphics.drawrectangles?view=dotnet-plat-ext-6.0#system-drawing-graphics-drawrectangles(system-drawing-pen-system-drawing-rectanglef())