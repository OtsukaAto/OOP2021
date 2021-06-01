using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-toi") 
            {
                PrintMeterToInchList(1,10);
            } else {
                PrintInchMeterList(1.10);
            }
        }

        private static void PrintInchMeterList(double v)
        {
            throw new NotImplementedException();
        }

        private static void PrintMeterToInchList(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
