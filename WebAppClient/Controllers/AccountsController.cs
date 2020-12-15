using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppClient.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebAppClient.Controllers
{
    public class AccountsController : Controller
    {
        private string url = "http://http://localhost:61505/api/Accounts";
        private HttpClient httpClient = new HttpClient();
        public IActionResult Index(string cus, string doctor)
        {
             var model = JsonConvert.DeserializeObject<IEnumerable<Accounts>>(httpClient.GetStringAsync(url).Result);
            ViewBag.cus = cus;
            ViewBag.doctor = doctor; 
            return View(model);
        }

        //Client Profile
        public IActionResult ClientProfile (Accounts accounts)
        {
            ViewBag.cus = HttpContext.Session.GetString("Customer");
           
            return View(accounts);
        }
        //Doctor Profile
        public IActionResult DoctorProfile(Accounts accounts)
        {
            ViewBag.doctor = HttpContext.Session.GetString("Doctor");
            return View(accounts);
        }
        // login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int accID, string password)
        {
            var model = JsonConvert.DeserializeObject<IEnumerable<Accounts>>(httpClient.GetStringAsync(url).Result);
            try
            {
                var acc = model.SingleOrDefault(u => u.AccountID.Equals(accID)); 
                if (acc != null)
                {
                    if (acc.Password.Equals(password))
                    {
                        if (acc.Role.Equals("Doctor")) 
                        {
                   
                            ViewBag.Doctor = accID;
                            return View("DoctorProfile");
                        }
                        else
                        {
                           
                            return RedirectToAction("ClientProfile", acc);
                        }
                    }
                    else
                    {
                        ViewBag.Msg = "Invalid password";
                    }
                }
                else
                {
                    ViewBag.Msg = "Account not found ...";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Msg = ex.Message;
            }
            return View();
        }
    }
}
