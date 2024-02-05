using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
    public class VendorsController : Controller
    {
        private static List<Vendor> vendors = new List<Vendor>();

        public IActionResult Index()
        {
            return View(vendors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Vendor vendor)
        {
            vendor.VendorId = vendors.Count + 1;
            vendors.Add(vendor);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var vendor = vendors.Find(v => v.VendorId == id);
            if (vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }

        [HttpGet]
        public IActionResult CreateOrder(int vendorId)
        {
            var vendor = vendors.Find(v => v.VendorId == vendorId);
            if (vendor == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(int vendorId, Order order)
        {
            var vendor = vendors.Find(v => v.VendorId == vendorId);
            if (vendor == null)
            {
                return NotFound();
            }

            order.OrderId = vendor.Orders.Count + 1;
            vendor.Orders.Add(order);

            return RedirectToAction("Details", new { id = vendorId });
        }
    }
}
