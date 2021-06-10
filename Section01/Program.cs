using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args)
        {
            var Session = new Dictionary<string,object>();
            Session["MyProduct"] = null;

            var product = Session["MyProduct"] as Product;
            if (product ==null) 
            {
                //productが取得できなかった時の処理
                Console.WriteLine("productが取得出来なかった。");
                //productが取得出来た時の処理
                Console.WriteLine("productが取得出来た。");
            
            }
        }

        private static Product GetProductA() 
        {
            Sale sale = new Sale();
            return sale?.Product; //null演算子
        }
    }

    class Sale 
    {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }

}
