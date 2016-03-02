using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigital
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.AddDigits(339594));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int AddDigits(int num)
        {
            if (num < 10)
                return num;
            else
            {
                string s = num.ToString();
                int len = s.Length;
                int i = 0;
                int result = 0;
                for (i = 0; i < len; i++)
                {
                    int a = num % 10;
                    result += a;
                    num /= 10;
                }
                return AddDigits(result);
            }
        }

    }
}
