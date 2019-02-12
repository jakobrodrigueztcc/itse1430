using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    ///<summary>Represents a game.</summary>
    public class Game
    {
        ///<summary>The name of the game.</summary>
        public string Name //property. itself, it doesnt have data.
        {
            get { return _name ?? ""; } //null coalesce operator. if left is null, use right instead.
            set { _name = value; } //setter for the _field
        }

        private string _name = ""; //field. MUST be private.

        ///<summary>The game's publisher.</summary>
        public string Publisher
        {
            get { return _publisher ?? ""; }
            set { _publisher = value; }
        }
        private string _publisher = "";

        //Calculated property
        public bool IsCoolGame
        {
            get { return Publisher != "EA"; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private decimal _price;

        public bool Owned
        {
            get { return _owned; }
            set { _owned = value; }
        }
        private bool _owned;

        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }
        private bool _completed;

        //Can init the data as well
        //public string[] Genres { get; set; }

        // Don't use array properties because they require cloning
        // and are inefficient
        //public string[] Genres
        //{
        //    get 
        //    {
        //        var temp = new string[_genres.Length];
        //        Array.Copy(_genres, temp, _genres.Length);
        //        return temp;
        //    }
        //}
        //private string[] _genres;

        //public string[] genres = new string[10];
        //private decimal realPrice = Price;

        ///<summary>Validates the object.</summary>
        public bool Validate()
        {
            //Name required
            if (String.IsNullOrEmpty(Name))
                return false;

            //Price >= 0
            if (Price < 0)
                return false;

            return true;
        }
    }
}
