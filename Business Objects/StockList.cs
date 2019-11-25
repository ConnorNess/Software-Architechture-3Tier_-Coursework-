using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Objects
{
    public class StockList
    {
        public static StockList reference;

        private List<Stock> listStock = new List<Stock>();

        public void add(Stock newStock)
        {
            listStock.Add(newStock);
        }

        public List<Stock> GetStockList
        {
            get
            {
                return listStock;
            }
        }

        public List<Stock> SetStockList
        {
            set
            {
                listStock = value;
            }
        }

        public static StockList getCurrent()
        {
            if (reference == null)
            {
                reference = new StockList();
            }
            return reference;
        }

        public Stock find(int id)
        {
            foreach (Stock p in listStock)
            {
                if (id == p.RefNo)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
