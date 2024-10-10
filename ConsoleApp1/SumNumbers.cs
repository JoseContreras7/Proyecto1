using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SumNumberEven
    {
        public int SumNumber(int[] arrayNumbers)
        {
            return arrayNumbers.Where(n => n % 2 == 0).Sum();

        }
    }
}
