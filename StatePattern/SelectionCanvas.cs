using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SelectionCanvas : Canvas
    {
        public override void MouseDown()
        {
                Console.WriteLine("Selection Icon");
        }


        public override void MouseUp()
        {
                Console.WriteLine("Draw dashed rectangle");
        }

    }
}
