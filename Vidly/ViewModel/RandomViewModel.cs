using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.ViewModel
{
    public class RandomViewModel
    {
        private List<Models.Movie> _randomMovies = new  List<Models.Movie>();

        public List<Models.Movie> RandomMovies {
            get
            {
                return _randomMovies;
            }

            set
            {
                _randomMovies = value;
            } }
    }
}