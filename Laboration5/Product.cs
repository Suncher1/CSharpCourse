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
        public int Playtime
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
                //if(!string.IsNullOrEmpty(Gametime))
                //{
                //    return $"{Id} {Name}, {Gametime} min ({Stock - Reserved})";
                //}
                return $"{Name.Truncate(28)} ({Stock - Reserved}) {Price} kr";
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
        public void Reserve()
        {
            Reserved++;
        }
        public void UnReserve()
        {
            Reserved--;
        }
        public void Return()
        {
            Stock++;
        }
    }
}
