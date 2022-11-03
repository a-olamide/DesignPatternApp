using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Tool
{
    public class Canvas
    {
        private Tool currentTool;

        public void MouseDown()
        {
            currentTool.mouseDown();
        }
        public void MouseUp()
        {
            currentTool.mouseUp();
        }

        public Tool GetCurrentTool() { return currentTool; }

        public void SetCurrentTool(Tool currentTool) 
        { 
            this.currentTool = currentTool; 
        }  
    }
}
