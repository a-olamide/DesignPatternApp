using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class BrushCanvas : Canvas
    {
        public override void MouseDown()
        {
            Console.WriteLine("Brush Icon");
        }


        public override void MouseUp()
        {
            Console.WriteLine("Eraser something");
        }
    }
}
