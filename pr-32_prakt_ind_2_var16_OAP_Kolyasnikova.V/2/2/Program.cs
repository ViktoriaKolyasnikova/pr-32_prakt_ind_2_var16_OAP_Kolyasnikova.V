using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader srr = new StreamReader("t.txt");
            string q;
            Console.WriteLine("Содержимое тестового файла:");
            while (srr.EndOfStream != true)
            {
                q = srr.ReadLine();
                Console.WriteLine(q);
            }
            Console.WriteLine();
         
            StreamReader sr = new StreamReader("t.txt");
            Queue p = new Queue();
            Queue o = new Queue();
            string[] t = sr.ReadToEnd().Split();

            for (int i = 0; i < t.Length; i++)
            {
                int r = 0;
                if (int.TryParse(t[i], out r))
                {
                    if (r > 0)
                    {
                        p.Enqueue(r);
                    }
                    if (r < 0)
                    {
                        o.Enqueue(r);
                    }
                }
            }
            Console.Write("Положительные числа: ");
            foreach (int c in p)
            {
                Console.Write(" "+ c);
            }
            Console.Write("\nОтрицательные числа: ");
            foreach (int c in o)
            {
                Console.Write(" "+ c);
            }
            Console.ReadKey();
            
        }
    }
}
