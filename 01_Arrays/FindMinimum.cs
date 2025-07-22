using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_._01_Arrays
{
    public class FindMinimum
    {

        public static void Run()
        {
            int[] numbers = { 34, 12, 5, 78, 10, 9 };


            int min=numbers[0];

            for(int i=1;i<numbers.Length; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Minimum value is :" + min);
        }
    }
}
