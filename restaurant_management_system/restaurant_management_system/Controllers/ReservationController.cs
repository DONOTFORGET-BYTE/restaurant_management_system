using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restaurant_management_system.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        // GET: Reservation
        public ActionResult Index()
        {
            int customer_id = 0;
            using (var context = new DataClasses1DataContext())
            {
                var user_details = (from x in context.customers where x.customer_email == User.Identity.Name select x).FirstOrDefault();
                customer_id = user_details.customer_id;
            }
            
             var reservations = (from x in dc.reservations where x.customer_id == customer_id select x).ToList();
            
            return View(reservations);
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            var reservation_details = (from x in dc.reservations where x.reservation_id == id select x).FirstOrDefault();
            return View(reservation_details);
        }

        // GET: Reservation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reservation/Create
        [HttpPost]
        public ActionResult Create(reservation obj)
        {
            int customer_id = 0;
            using (var context = new DataClasses1DataContext())
            {
                var user_details = (from x in context.customers where x.customer_email == User.Identity.Name select x).FirstOrDefault();
                customer_id = user_details.customer_id;
            }
            try
            {
                // TODO: Add insert logic here
                using (var context = new DataClasses1DataContext())
                {
                    int id = context.reservations.Max(m => m.reservation_id);
                    if (id < 0) id = 0;
                    obj.reservation_id = id + 1;
                    obj.customer_id = customer_id;
                    context.reservations.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                return RedirectToAction("Index");
            }
            catch(InvalidOperationException f)
            {
                using (var context = new DataClasses1DataContext())
                {
                    int id = 0;
                    obj.reservation_id = id + 1;
                    obj.customer_id = customer_id;
                    context.reservations.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                return View();
            }
        }

        // GET: Reservation/Edit/5
        public ActionResult Edit(int id)
        {
            var update_reservation = (from x in dc.reservations where x.reservation_id == id select x).FirstOrDefault();
            return View(update_reservation);
        }

        // POST: Reservation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, reservation obj)
        {
            try
            {
                // TODO: Add update logic here
                var update_reservation = (from x in dc.reservations where x.reservation_id == obj.reservation_id select x).FirstOrDefault();
                update_reservation.reservation_id = obj.reservation_id;
                update_reservation.startdatetime = obj.startdatetime;
                update_reservation.reservation_status = obj.reservation_status;
                update_reservation.description = obj.description;
                update_reservation.type_of_table = obj.type_of_table;
                update_reservation.purpose = obj.purpose;
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservation/Delete/5
        public ActionResult Delete(int id)
        {
            var delete_reservation = (from x in dc.reservations where x.reservation_id == id select x).FirstOrDefault();
            dc.reservations.DeleteOnSubmit(delete_reservation);
            dc.SubmitChanges();
            return View();
        }

        // POST: Reservation/Delete/5
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
