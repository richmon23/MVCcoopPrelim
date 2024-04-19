using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using RetizaCoopPrelim.Entities;


namespace RetizaCoopPrelim.Controllers
{
    
       public class UserTypeController : Controller
    {
        private readonly PrelimmvcnewContext _context;

        public UserTypeController(PrelimmvcnewContext context)
        {
            _context = context;
        }

       public IActionResult Index()
        {
            var model = _context.UserTypes.ToList();
            return View(model);
        }


         [HttpGet]

        public IActionResult Create()
        {
             var UserType = _context.UserTypes.ToList();
            ViewData["UserType"] = UserType;
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserType b)
        {      
            
            _context.UserTypes.Add(b);
             _context.SaveChanges();

             return RedirectToAction("Index");
         

        }

         [HttpGet]

        public IActionResult Update(int id)
        {
            var usertype = _context.UserTypes.Where(q => q.Id == id).FirstOrDefault();
            return View(usertype);
        }

        [HttpPost]
        public IActionResult Update(UserType b) 
        {
            _context.UserTypes.Update(b);
            _context.SaveChanges();
            return RedirectToAction("Index");
          
        }
       
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var usertype = _context.UserTypes.Where(q => q.Id == id).FirstOrDefault();
            _context.UserTypes.Remove(usertype);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}