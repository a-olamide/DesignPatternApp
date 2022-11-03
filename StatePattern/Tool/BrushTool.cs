using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Tool
{
    public class BrushTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Brush Icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Eraser something");
        }
    }
}
