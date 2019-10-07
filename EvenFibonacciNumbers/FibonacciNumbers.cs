using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    public class FibonacciNumbers
    {
        public int FinonacciSum()
        {
            int totalSum = 0;
            int evenSum = 0;

            int firstNum = 1;
            int secondNum = 2;
            
            while (totalSum < 4000000)
            {
                totalSum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = totalSum;

                if (totalSum % 2 == 0)
                {
                    evenSum += totalSum;
                }
            }
            return evenSum;
        }
    }
}
