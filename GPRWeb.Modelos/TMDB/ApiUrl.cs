using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRWeb.Modelos.TMDB
{
    public class ApiUrl
    {
        public static string GetMovieByName { 
            get {
                return string.Format("{0}{1}{2}", ConfigurationManager.AppSettings["GetByName"], ConfigurationManager.AppSettings["ApiKey"], "&query=");
            }
        }
        public static string GetTrending
        {
            get
            {
                return string.Format("{0}{1}", ConfigurationManager.AppSettings["GetTrending"], ConfigurationManager.AppSettings["ApiKey"]);
            }
        }
    }
}
