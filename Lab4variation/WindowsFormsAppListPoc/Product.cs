using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppListPoc
{
    public class Product
    {

        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }



        public int Stock
        {
            get;
            set;
        }

        public int Reserved
        {
            get;
            set;
        }

        public string ProductStockInfo
        {
            get
            {
                return $"{this.Title} ({this.Stock.ToString()})";
            }
        }


        public string ProductReservedInfo
        {
            get
            {
                return $"{this.Title} ({this.Reserved.ToString()})";
            }
        }

        //public override string ToString()
        //{
        //    return $"{Title} {Description}";
        //}

    }
}
