using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Tool
{
    public class SelectionTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Selection Icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw dashed rectangle");
        }
    }
}
