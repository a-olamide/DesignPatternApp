using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class TextFile : DataProcessor
    {
        
        public override void ReadData()
        {
            Console.WriteLine("Read data from text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("process data from text file");
        }

       
    }
}
