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
                return $"{this.Id} {this.Name} ({this.Stock})";
            }
        }
        public string DisplayListOfProducts
        {
            get
            {
                return $"{this.Id} {this.Name} ({this.Stock})";
            }
        }
        #endregion
    }
}
