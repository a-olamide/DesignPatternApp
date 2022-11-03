using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SortedNumbers : ISortedNumbers
    {
        private readonly ISortStrategy _sort;

        public SortedNumbers(ISortStrategy sort)
        {
            _sort = sort;
        }

        public void sort(int[] items)
        {
            var sorted = _sort.Sort(items);
            foreach (var item in sorted)
                Console.WriteLine(item);
        }
    }
}
