using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RetizaCoopPrelim.Entities;

namespace RetizaCoopPrelim.Controllers
{

    public class ClientController : Controller
    {
        private readonly PrelimmvcnewContext _context;
        
        public ClientController(PrelimmvcnewContext context)
        {

                _context = context;
        }

        public IActionResult Index()
        {
            var client = _context.ClientInfos.ToList();
            return View(client);
        }

        [HttpGet]

        public IActionResult Create()
        {
            var UserType = _context.UserTypes.ToList();
            ViewData["UserType"] = UserType;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClientInfo b)
        {
            
                if (ModelState.IsValid)
                {
                    _context.ClientInfos.Add(b);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                // If ModelState is not valid, return the view with validation errors
                var UserType = _context.UserTypes.ToList();
                ViewData["UserType"] = UserType;
                return View(b);
        }

        [HttpGet]

        public IActionResult Update(int id)
        {
            var usertype = _context.UserTypes.ToList();
            var clientInfo = _context.ClientInfos.FirstOrDefault(q => q.Id == id);
            ViewData["UserTypes"] = usertype;
            return View(clientInfo);
        }

        [HttpPost]
        public IActionResult Update(ClientInfo b)
        {
            // _context.ClientInfos.Update(b);
            // _context.SaveChanges();
            // return RedirectToAction("Index");
             if (ModelState.IsValid)
        {
            _context.ClientInfos.Update(b);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // If ModelState is not valid, return the view with validation errors
        var usertype = _context.UserTypes.ToList();
        ViewData["UserTypes"] = usertype;
        return View(b);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var clientInfo = _context.ClientInfos.Where(q => q.Id == id).FirstOrDefault();
            _context.ClientInfos.Remove(clientInfo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

    



