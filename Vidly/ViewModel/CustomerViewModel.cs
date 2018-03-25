using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.ViewModel
{
    public class CustomerViewModel
    {
        private List<Models.Customer> _lstViewModel = new List<Models.Customer>();

        public List<Models.Customer> Customers { get { return _lstViewModel; } set { _lstViewModel = value; } }

    }
}