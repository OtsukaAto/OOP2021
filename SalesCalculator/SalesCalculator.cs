using System;
using System.Collections.Generic;
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

        //List 2-17
        //店舗別売り上げを求める
        public Dictionary<string,int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(Sale sale in _sales) 
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
    }
}
