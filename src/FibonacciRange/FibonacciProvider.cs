using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRange
{
    public class FibonacciProvider
    {
        public static int[] GetRange(int amountOfNumbers, bool useMathematician = false)
        {
            var returnValue = new int[amountOfNumbers];

            for (var i = 0; i < amountOfNumbers; i++)
            {
                switch (i)
                {
                    case 0:
                        returnValue[i] = useMathematician ? 1 : 0;
                        break;
                    case 1:
                        returnValue[i] = useMathematician ? 2 : 1;
                        break;
                    default:
                        returnValue[i] = returnValue[i - 1] + returnValue[i - 2];
                        break;
                }
            }
            return returnValue;
        }
    }
}
