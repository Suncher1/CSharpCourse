using Laboration4.Extensions;

namespace Laboration4
{
    public class Product
    {
        //id,namn,pris,författare,genre,format,språk,plattform,speltid,antal
        #region Properties
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public string Genre
        {
            get;
            set;
        }
        public string Format
        {
            get;
            set;
        }
        public string Language
        {
            get;
            set;
        }
        public string Platform
        {
            get;
            set;
        }
        public string Gametime
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

        public string DisplayInStorage
        {
            get
            {
                return $"{Name.Truncate(28)} ({Stock})";
            }
        }
        public string DisplayListOfProducts
        {
            get
            {
                return $"{Name.Truncate(28)} ({Stock - Reserved})";
            }
        }
        public string DisplayReservedProducts
        {
            get
            {
                return $"{Name.Truncate(28)} ({Reserved})";
            }
        }
        #endregion

        //Kollar om man kan köpa eller inte beroende på hur många som finns och hur många som valts
        public bool EligibleToBuy()
        {
            if (Stock > Reserved)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Ökar antalet på variablen reserved med ett
        public void Reserve()
        {
            Reserved++;
        }

        //Minskar antalet på variablen reserved med ett
        public void UnReserve()
        {
            Reserved--;
        }

        //Ökar antalet på variabeln stock med ett
        public void Return()
        {
            Stock++;
        }
    }
}
