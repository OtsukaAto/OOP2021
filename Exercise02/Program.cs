using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01;

namespace Exercise02 {
    class Program {
        static void Main(string[] args)
        {
            //4.2.1
            var ymCollection = new YearMonth[]
            {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };

            //4.2.2
            Exercise02_2(ymCollection);
            Console.WriteLine("---");

            //4.2.4
            Exercise02_4(ymCollection);
            Console.WriteLine("---");

            //4.2.5
            Exercise02_5(ymCollection);
            Console.WriteLine("---");
        }

        private static void Exercise02_2(YearMonth[] ymCollection)
        {
            foreach (var ym in ymCollection) 
            {
                Console.WriteLine(ym.Year);
            }
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] ymCollection) 
        {
            foreach (var ym in ymCollection) 
            {
                //21世紀ならTrue(プロパティ)
                if (ym.Is21Century) 
                {
                    return ym;
                }
            }
            //ここまで来たら21世紀が存在しない
            return null;
        }

        private static void Exercise02_4(YearMonth[] ymCollection)
        {
            var yearmonth = FindFirst21C(ymCollection);
            //条件演算子
            var s = yearmonth != null ? yearmonth.ToString():"21世紀のデータはありません";
            Console.WriteLine(s);
        }

        private static void Exercise02_5(YearMonth[] ymCollection)
        {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach(var ym in array) 
            {
                Console.WriteLine(ym);
            }
        }
    }
}
