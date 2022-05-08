using System;

namespace Problema1
{/// <summary>
/// Problem with stack
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();
            Random rnd = new Random();
            for(int i=0;i<100;i++)
            {
                s.Push(rnd.Next(1, 100));
            }
            Console.WriteLine("Numarul elementelor din stiva este " + s.Count);
            int S = 0;
            while(s.Count>0)
            {
                S=S+s.Pop();
            }
            Console.WriteLine($"Suma tuturor elementelor din stiva este {S}");
            Console.WriteLine($"Numarul de elemente din stiva este {s.Count}");
            s.Push(1);
            Console.WriteLine($"Elemntul din varful stivei este {s.Peek()}");
            /// cream o stiva care stocheaza valori de tip siruri de caractere "string-uri"
            /// 
            MyStackGenerric<string> R = new MyStackGenerric<string>();
            R.Push("Hola");
            R.Push("Hello");
            while(R.Count>0)
            {
                Console.WriteLine(R.Pop());
            }
        }

    }
}
