using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restaurant_management_system.Controllers
{
    [Authorize]
    public class CustomersController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        // GET: Customers
        public ActionResult Index()
        {
            var customers = dc.customers.ToList();
            return View(customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            var customer_details = (from x in dc.customers where x.customer_id == id select x).FirstOrDefault();
            return View(customer_details);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(customer obj)
        {
            try
            {
                // TODO: Add insert logic here
                using (var context = new DataClasses1DataContext())
                {
                    int id = context.customers.Max(m => m.customer_id);
                    obj.customer_id = id + 1;
                    context.customers.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                return RedirectToAction("Index");
            }
            catch(InvalidOperationException f)
            {
                using (var context = new DataClasses1DataContext())
                {
                    int id = 0;
                    obj.customer_id = id + 1;
                    context.customers.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                return RedirectToAction("Index");
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            var update_customer = (from x in dc.customers where x.customer_id == id select x).FirstOrDefault();
            return View(update_customer);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, customer obj)
        {
            try
            {
                // TODO: Add update logic here
                var update_customer = (from x in dc.customers where x.customer_id == obj.customer_id select x).FirstOrDefault();
                update_customer.customer_id = obj.customer_id;
                update_customer.customer_email = obj.customer_email;
                update_customer.password = obj.password;
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            var delete_customer = (from x in dc.customers where x.customer_id == id select x).FirstOrDefault();
            dc.customers.DeleteOnSubmit(delete_customer);
            dc.SubmitChanges();
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
