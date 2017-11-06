using CallingRestApiFromController.Models;
using CallingRestApiFromController.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallingRestApiFromController.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomerClient customerClient = new CustomerClient();
            List<Customer> customers = customerClient.findAll().ToList();
            return View(customers);
        }
        public ActionResult Create()
        {
            Customer customer = new Customer();
            return View(customer);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            CustomerClient customerClient = new CustomerClient();
            bool result = customerClient.Create(customer);
            return RedirectToAction("Index");
        }
    }
}