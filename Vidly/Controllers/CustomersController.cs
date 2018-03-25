using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        ApplicationDbContext appDbContext = new ApplicationDbContext();
        // GET: Customers
        public ActionResult Index()
        {
            CustomerViewModel customerViewModel = new CustomerViewModel();
            //Models.Customer c1 = new Customer()
            //{
            //    Id = 1,
            //    Name = "Vinod"
            //};

            //Customer c2 = new Customer()
            //{
            //    Id = 2,
            //    Name = "Vivan"
            //};

            //customerViewModel.Customers.Add(c1);
            //customerViewModel.Customers.Add(c2);
            customerViewModel.Customers = appDbContext.Customers.Include(c=> c.MembershipType).ToList<Customer>();
            return View(customerViewModel);
        }

        public ActionResult ById(int id)
        {
            CustomerDetail cd = new CustomerDetail();

            Customer cust = appDbContext.Customers.ToList<Customer>().Where<Customer>(c => c.Id == id).FirstOrDefault<Customer>();

            cd.CustomerInfo = cust;
            return View(cd);
            //return Content(String.Format("ID of the Customer : {0}", id));
        }

        public ActionResult New()
        {
            NewCustomerViewModel newCustomer = new NewCustomerViewModel();
            newCustomer.CurrentCustomer = new Customer();
            newCustomer.MembershipTypes = appDbContext.MembershipTypes.ToList<MembershipType>();

            return View(newCustomer);
        }

        [HttpPost]
        public ActionResult Create(NewCustomerViewModel customer)
        {
            try
            {

                if(!ModelState.IsValid)
                {
                    customer.MembershipTypes = appDbContext.MembershipTypes.ToList<MembershipType>();
                    return View("New", customer);
                }
                Customer cust = customer.CurrentCustomer;
                appDbContext.Customers.Add(cust);
                appDbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
            
            return RedirectToAction("Index", "Customers");
        }
    }
}