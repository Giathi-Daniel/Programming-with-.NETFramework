using System;

namespace Calculator {
    class Program {
        stativ void Main(string[] args) {
            Console.Write("Enter First Number.: ");
            int a =Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number.: ");
            int b =Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Number.: ");
            int c =Convert.ToInt32(Console.ReadLine());

            Console.Write(a+b+c);
            int Answer = Convert.ToInt32(Console.ReadLine());
            Console.Write("Answer is.: " + Answer);
        }
    }
}