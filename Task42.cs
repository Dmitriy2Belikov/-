using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Quest
{
    class Task42
    {
        public static char[] eng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
        static void Main()
        {
            var text = File.ReadAllText(@"Укажите путь к файлу здесь!!!");
            var word = new StringBuilder();
            var words = new List<string>();
            var counter = 0;

            foreach (var letter in text)
            {
                if (char.IsLetter(letter))
                    word.Append(letter);
                else if (word.ToString().Length > 0)
                {
                    words.Add(word.ToString());
                    word.Clear();
                }
            }

            foreach(var element in words)
            {
                int i = 0;

                while(GetTriangleNum(i) <= GetWordNum(element))
                {
                    var trNum = GetTriangleNum(i);
                    var wrNum = GetWordNum(element);
                    if (GetTriangleNum(i) == GetWordNum(element))
                    {
                        counter++;
                        break;
                    }
                    i++;
                }
            }

            Console.WriteLine(counter);
        }

        public static double GetTriangleNum(int number)
        {
            return 0.5 * number * (number + 1);
        }

        public static int GetWordNum(string word)
        {
            var num = 0;

            foreach (var letter in word)
                for (int i = 0; i < eng.Length; i++)
                    if (letter == eng[i]) num += i + 1;

            return num;
        }
    }
}