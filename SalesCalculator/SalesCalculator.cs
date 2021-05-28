using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売り上げ集計クラス
    class SalesCalculator 
    {
        private List<Sale> _sales;

        //コンストラクタ
        public SalesCalculator(List<Sale> sales) 
        {
            _sales = sales;
        }

        private static List<Sale> ReadSales(string filePath) 
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

        //List 2-17
        //店舗別売り上げを求める
        public Dictionary<string,int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(Sale sale in _sales) 
            {
                if (dict.ContainsKey(sale.ShopName))
                    //既に
                    dict[sale.ShopName] += sale.Amount;
                else
                    //
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
    }
}
