using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class EraserCanvas : Canvas
    {
        public override void MouseDown()
        {
            Console.WriteLine("Eraser Icon");
        }

        public override void MouseUp()
        {
            throw new NotImplementedException();
        }
    }
}
