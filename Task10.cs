using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            var list = new List<int>();
            list.Add(number);

            while (number < 2000000)
            {
                bool flag = true;
                number++;
                for (int i = 0; i < list.Count; i++)
                {
                    if (number % list[i] == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag) list.Add(number);
            }

            long sum = 0;
            for (int i = 0; i < list.Count; i++)
                sum += list[i];

            Console.WriteLine(sum);
        }
    }
}
