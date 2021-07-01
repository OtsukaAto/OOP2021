using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            Execise1_1(numbers);
            Console.WriteLine("-----");

            Execise1_2(numbers);
            Console.WriteLine("-----");

            Execise1_3(numbers);
            Console.WriteLine("-----");

            Execise1_4(numbers);
            Console.WriteLine("-----");

            Execise1_5(numbers);
        }
        private static void Execise1_1(int[] numbers)
        {
            var max = numbers.Max();
            Console.WriteLine(max);
        }
        private static void Execise1_2(int[] numbers)
        {
            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip))
                Console.WriteLine(n);
        }
        private static void Execise1_3(int[] numbers)
        {
            var strs = numbers.Select(n => n.ToString());
            foreach (var s in strs)
                Console.WriteLine(s);
        }
        private static void Execise1_4(int[] numbers)
        {


        }
        private static void Execise1_5(int[] numbers)
        {

        }
    }
}
