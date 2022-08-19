using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using restaurant_management_system.Models;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;
using System.Web.Security;

namespace restaurant_management_system.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(customer obj)
        {
            using (var context = new DataClasses1DataContext())
            {
                bool isValid = context.customers.Any(x => x.customer_email == obj.customer_email && x.password.ToString() == obj.password.ToString());
                bool isCorrectRestaurant = context.customers.Any(x => x.restaurant_id == obj.restaurant_id);
                if (isValid)
                {
                    if (!isCorrectRestaurant)
                    {
                        ModelState.AddModelError("", "user is not registered under restaurant");
                    }else
                    {
                        FormsAuthentication.SetAuthCookie(obj.customer_email, false);
                        //based on email type redirect to different views
                        if (obj.customer_email == "admin")
                        {
                            return RedirectToAction("Index", "Restaurant");
                        }
                        else
                        {
                            //redirect to landing page for users
                            return RedirectToAction("Index", "Reservation");
                        }

                    }
                } 
                    
                ModelState.AddModelError("", "Invalid username and password");
                return View();
            }
            
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(customer obj)
        {
            using (var context = new DataClasses1DataContext())
            {
                int id = 0;
                try
                {
                    id = context.customers.Max(m => m.customer_id);
                    obj.customer_id = id + 1;
                    context.customers.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }
                catch(InvalidOperationException f)
                {
                    obj.customer_id = id + 1;
                    context.customers.InsertOnSubmit(obj);
                    context.SubmitChanges();
                }   
            }

            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}