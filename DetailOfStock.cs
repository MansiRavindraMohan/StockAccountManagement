using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class DetailOfStock
    {
        public string NameOfStock;
        public int Share;
        public int Price;
    }
    public class StockDetails
    {
        public List<DetailOfStock> Stock;
    }
}
