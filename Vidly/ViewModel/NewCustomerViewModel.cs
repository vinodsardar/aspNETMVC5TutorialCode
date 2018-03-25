using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<Vidly.Models.MembershipType> MembershipTypes { get; set; }
        public Vidly.Models.Customer CurrentCustomer { get; set; }


    }
}