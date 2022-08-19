using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace restaurant_management_system.Controllers
{
    [Authorize]
    public class AdminReservationController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        // GET: AdminReservation
        public ActionResult Index()
        {
            var reservations = dc.reservations.ToList();
            return View(reservations);
        }

        // GET: AdminReservation/Details/5
        public ActionResult Details(int id)
        {
            var reservation_details = (from x in dc.reservations where x.reservation_id == id select x).FirstOrDefault();
            return View(reservation_details);
        }

        // GET: AdminReservation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminReservation/Create
        [HttpPost]
        public ActionResult Create(reservation obj)
        {
            try
            {
                // TODO: Add insert logic here
                using (var context = new DataClasses1DataContext())
                {
                    int id = context.reservations.Max(m => m.reservation_id);
                    if (id < 0) id = 0;
                    obj.reservation_id = id + 1;
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
                    context.reservations.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                return RedirectToAction("Index");
            }
        }

        // GET: AdminReservation/Edit/5
        public ActionResult Edit(int id)
        {
            var update_reservation = (from x in dc.reservations where x.reservation_id == id select x).FirstOrDefault();
            return View(update_reservation);
        }

        // POST: AdminReservation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, reservation obj)
        {
            try
            {
                // TODO: Add update logic here
                var update_reservation = (from x in dc.reservations where x.reservation_id == obj.reservation_id select x).FirstOrDefault();
                update_reservation.reservation_id = obj.reservation_id;
                update_reservation.purpose = obj.purpose;
                update_reservation.type_of_table = obj.type_of_table;
                update_reservation.description = obj.description;
                update_reservation.startdatetime = obj.startdatetime;
                update_reservation.customer_id = obj.customer_id;
                update_reservation.reservation_status = obj.reservation_status;
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminReservation/Delete/5
        public ActionResult Delete(int id)
        {
            var delete_reservation = (from x in dc.reservations where x.reservation_id == id select x).FirstOrDefault();
            dc.reservations.DeleteOnSubmit(delete_reservation);
            dc.SubmitChanges();
            return View();
        }

        // POST: AdminReservation/Delete/5
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
