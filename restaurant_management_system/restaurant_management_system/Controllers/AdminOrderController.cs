using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restaurant_management_system.Controllers
{
    [Authorize]
    public class AdminOrderController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        // GET: AdminOrder
        public ActionResult Index()
        {
            var orders = dc.orders.ToList();
            return View(orders);
        }

        // GET: AdminOrder/Details/5
        public ActionResult Details(int id)
        {
            var order_details = (from x in dc.orders where x.order_id == id select x).FirstOrDefault();
            return View(order_details);
        }

        // GET: AdminOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminOrder/Create
        [HttpPost]
        public ActionResult Create(order obj)
        {
            try
            {
                // TODO: Add insert logic here
                using (var context = new DataClasses1DataContext())
                {
                    int id = context.orders.Max(m => m.order_id);
                    if (id < 0) id = 0;
                    obj.order_id = id + 1;
                    context.orders.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                return RedirectToAction("Index");
            }
            catch (InvalidOperationException f)
            {
                using (var context = new DataClasses1DataContext())
                {
                    int id = 0;
                    obj.order_id = id + 1;
                    context.orders.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                return RedirectToAction("Index");
            }
        }

        // GET: AdminOrder/Edit/5
        public ActionResult Edit(int id)
        {
            var update_order = (from x in dc.orders where x.order_id == id select x).FirstOrDefault();
            return View(update_order);
        }

        // POST: AdminOrder/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, order obj)
        {
            try
            {
                // TODO: Add update logic here
                var update_order = (from x in dc.orders where x.order_id == obj.order_id select x).FirstOrDefault();
                update_order.order_id = obj.order_id;
                update_order.order_name = obj.order_name;
                update_order.order_price = obj.order_price;
                update_order.customer_id = obj.customer_id;
                update_order.restaurant_id = obj.restaurant_id;
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminOrder/Delete/5
        public ActionResult Delete(int id)
        {
            var delete_order = (from x in dc.orders where x.order_id == id select x).FirstOrDefault();
            dc.orders.DeleteOnSubmit(delete_order);
            dc.SubmitChanges();
            return View();
        }

        // POST: AdminOrder/Delete/5
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
