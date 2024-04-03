using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRWeb.Modelos.Movie
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Poster_path { get; set; }
        public string Release_date { get; set; }
        public string Backdrop_path { get; set; }
        public string Original_language { get; set; }
        public int Popularity { get; set; }
        public int Vote_average { get; set; }
        public int Vote_count { get; set; }
        //public List<int> Genre_ids { get; set; }
    }
}
