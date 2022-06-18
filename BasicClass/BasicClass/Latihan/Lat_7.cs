using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass.Latihan
{
    public class Lat_7
    {
        public static void main()
        {
            Numbers.Nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10 };

            Console.WriteLine("Sum number odd is " + Numbers.sumOdd());
        }
    }

    class Numbers
    {
        private static int[] nums;

        public static int[] Nums { get => nums; set => nums = value; }

        public static int sumOdd()
        {
            int sum = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] % 2 == 0)
                {
                    sum += Nums[i];
                }
            }

            return sum;
        }
    }
}
