using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using restaurant_management_system.Models;

namespace restaurant_management_system.Controllers
{
    [Authorize]
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public ActionResult Index()
        {
            var restaurants = dc.restaurants.ToList();
            
            return View(restaurants);
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            var restaurant_details = (from x in dc.restaurants where x.restaurant_id == id select x).FirstOrDefault();
            return View(restaurant_details);
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        public ActionResult Create(restaurant obj)
        {
            try
            {
                // TODO: Add insert logic here
                using (var context = new DataClasses1DataContext())
                {
                    int id = context.restaurants.Max(m => m.restaurant_id);
                    if (id < 0) id = 0;
                    obj.restaurant_id = id + 1;
                    context.restaurants.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                
                return RedirectToAction("Index");
            }
            catch(InvalidOperationException f)
            {
                using (var context = new DataClasses1DataContext())
                {
                    int id = 0;
                    obj.restaurant_id = id + 1;
                    context.restaurants.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                return RedirectToAction("Index");
            }
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            var update_restaurant = (from x in dc.restaurants where x.restaurant_id == id select x).FirstOrDefault();
            return View(update_restaurant);
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, restaurant obj)
        {
            try
            {
                // TODO: Add update logic here
                var update_restaurant = (from x in dc.restaurants where x.restaurant_id == obj.restaurant_id select x).FirstOrDefault();
                update_restaurant.restaurant_id = obj.restaurant_id;
                update_restaurant.restaurant_name = obj.restaurant_name;
                dc.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            var delete_restaurant = (from x in dc.restaurants where x.restaurant_id == id select x).FirstOrDefault();
            dc.restaurants.DeleteOnSubmit(delete_restaurant);
            dc.SubmitChanges();
            return View();
        }

        // POST: Restaurant/Delete/5
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
