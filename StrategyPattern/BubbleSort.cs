using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class BubbleSort : ISortStrategy
    {
        public int[] Sort(int[] inputArray)
        {
            var returnArray = inputArray;
            var length = returnArray.Length;

            for(int i = 0; i < length - 1; i++)
                for(int j = 0; j < length - 1; j++)
                {
                    if(returnArray[i] > returnArray[j+1])
                    {
                        var temp = returnArray[j];
                        returnArray[j] = returnArray[j+1];
                        returnArray[j+1] = temp;
                    }
                }
            return returnArray;

        }
    }
}
