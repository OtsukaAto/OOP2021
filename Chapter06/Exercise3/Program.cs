using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args)
        {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }
        private static void Exercise1_1(string text)
        {
            var dict = new Dictionary<char, int>();
            foreach (var c in text) {
                //大文字小文字を区別しないため全て大文字に変換して処理
                var uc = char.ToUpper(c);
                if('A' <= uc && uc <= 'Z') {
                    if (dict.ContainsKey(uc)) {
                        dict[uc]++;
                    } else {
                        dict[uc] = 1;
                    }
                }
            }
        }

        private static void Exercise1_2(string text)
        {
            var dict2 = new SortedDictionary<char, int>();
            foreach (var c in text) {
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z') {
                    if (dict2.ContainsKey(uc)) {
                        dict2[uc]++;
                    } else {
                        dict2[uc] = 1;
                    }
                }
            }
        }
    }
}
