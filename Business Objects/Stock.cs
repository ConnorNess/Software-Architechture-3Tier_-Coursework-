using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Business_Objects
{
    public class Stock
    {
        private String stockItem;
        private String stockQuantity;
        private String stockPrice;
        public int id;
        public static int idCount = 1;

        private bool anyError = false;
        

        public String StockItem
        {
            get
            {
                return stockItem;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        anyError = true;
                        throw new ArgumentException("Invalid");
                    }
                    stockItem = value;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        public String StockQuantity
        {
            get
            {
                return stockQuantity;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        anyError = true;
                        throw new ArgumentException("Invalid");
                    }
                    stockQuantity = value;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        public String StockPrice
        {
            get
            {
                return stockPrice;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        anyError = true;
                        throw new ArgumentException("Invalid");
                    }
                    stockPrice = value;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        public int RefNo
        {
            get
            {
                return id;
            }
            set
            {
                try
                {
                    if (value < 1)
                    {
                        anyError = true;
                        throw new ArgumentException("Booking ref was not valid");
                    }
                    id = value;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        public void refNoIncrement()
        {
            idCount++;
        }

        public int refNoCounter
        {
            get
            {
                return idCount;
            }
        }

    }
}
