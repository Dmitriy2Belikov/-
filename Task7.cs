using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var number = 1;
            var input = int.Parse(Console.ReadLine());
            var numList = new List<int>();
            while (counter < input)
            {
                var test = true;
                for (int i = 0; i < numList.Count; i++)
                    if (number % numList[i] == 0)
                    {
                        test = false;
                        break;
                    }

                if (test && number != 1)
                {
                    numList.Add(number);
                    counter++;
                }
                number++;
            }
            Console.WriteLine(numList[numList.Count - 1]);
        }
    }
}
