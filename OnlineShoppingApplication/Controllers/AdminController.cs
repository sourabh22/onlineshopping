﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShoppingApplication.Models;
using OnlineShoppingLibrary;
using OnlineShoppingServices.Models;

using OnlineShoppingServices.Models.DB;
using AdminService = OnlineShoppingServices.Models.AdminService;

namespace OnlineShoppingApplication.Controllers
{
    public class AdminController : Controller
    {

        AdminService service;
        ILogger<AdminController> log;
        public AdminController(ILogger<AdminController> log)
        {
            service = new AdminService();
            this.log = log;
        }

        public IActionResult Index()
        {

            return View();
        }
        [ErrorFilter]
        [HttpGet]
        public ActionResult Signup()
        {
            try
            {
                log.LogInformation("Executing GetProducts Method..");
                    log.LogInformation("This is a Test Message");

                }
            catch(Exception exception)
            {
                log.LogCritical("error message ,e.g, DO NOT DIVIDE BY ZERO......................"); // In catch block
                log.LogInformation("Executed GetProducts Method..");

            }
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Customer customer)
        {
           service.SignUp(customer);
            return View("SignUpSucecss");
        }
        public IActionResult Authenticate()
        {
            return View("Authenticate");
        }


        [HttpPost ]
        public ActionResult Authenticate(Credentials credentials)
        {
            try
            {
             
                int result = service.Authenticate(credentials);

                if (result == 0)
                {

                    ModelState.AddModelError("Email", "Invalid UserId or Password");

                    return View("Authenticate", credentials);


                }

                return RedirectToAction("Search", "Search", new { area = "" });
            }
            catch(Exception e)
            {
                ErrorViewModel m = new ErrorViewModel();
                m.RequestId = e.Message;
                return View("Error", m);
            }
        }
    }
}