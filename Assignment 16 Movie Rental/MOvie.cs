using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16_Movie_Rental
{
    class Movie
    {
        private string MovieName;
        private int MovieLength;
        private bool Available;

        public Movie(string MovieName, int MovieLength)
        {
            this.MovieName = MovieName;
            this.MovieLength = MovieLength;
            Available = true;
        }

        public string GetName()
        {
            return MovieName;
        }

        public int GetLength()
        {
            return MovieLength;
        }

        public bool isAvailable()
        {
            return Available;
        }

        public void BorrowMovie()
        {
            if (Available == true)
            {
                Available = false;
            }
        }

        public void ReturnMovie()
        {
            if(Available == false)
            {
                Available = true;
            }
        }
    }
}
