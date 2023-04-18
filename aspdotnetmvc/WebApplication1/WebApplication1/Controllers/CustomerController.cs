using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        static IList<Customer> customers = new List<Customer>();
        public ActionResult Index()
        {

            /**
              IList<Customer> customers = new List<Customer>();
              Customer customer1 = new Customer();
              customer1.Id = 1;
              customer1.Name = "Ravi";
              customer1.Email = "ravi@gmail.com";
              customer1.Location = "Bengaluru";
              customers.Add(customer1);
            

            IList<Customer> customers = new List<Customer>() { 
                new Customer{Id=1,Name="Ravi",Email="ravi@gmail.com",Location="Bengaluru" },
                 new Customer{Id=2,Name="Suresh",Email="suresh@gmail.com",Location="Mysuru" },
                 new Customer{Id=3,Name="Ganesh",Email="ganesh@gmail.com",Location="Shivamogga" }
            };
            **/
            return View(customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            var customer = customers.Where(cust => cust.Id == id).ToList().First();
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        // public ActionResult Create(FormCollection collection)
        public ActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                customers.Add(customer);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = customers.Where(cust => cust.Id == id).ToList().First();

            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        //  public ActionResult Edit(int id, FormCollection collection)
        public ActionResult Edit(int id, Customer updcustomer)
        {
            try
            {
                // TODO: Add update logic here
                /**
                var customer = customers.Where(cust => cust.Id == id).ToList().First();
                customer.Id = updcustomer.Id;
                customer.Name = updcustomer.Name;
                customer.Email = updcustomer.Email;
                customer.Location = updcustomer.Location;
               **/
                customers= customers.Select(cust => cust.Id == id ? updcustomer : cust).ToList();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = customers.Where(cust => cust.Id == id).ToList().First();

            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        //   public ActionResult Delete(int id, FormCollection collection)
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                // TODO: Add delete logic here

                //   customers = customers.Where(cust => cust.Id != id).ToList();
                var customertodel = customers.Where(cust => cust.Id == id).ToList().First();
                customers.Remove(customertodel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
