using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
namespace Vidly.ViewModel
{
    public class MoviesViewModel
    {

        private List<Models.Movie> _lstViewModel = new List<Models.Movie>();

        public List<Models.Movie> Movies { get { return _lstViewModel; } set {_lstViewModel=value; } }

    }
}