using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System;

namespace VendorOrder.Controllers
{
    public class VendorsController : Controller
    {
        public IActionResult Index()
        {
            return View(Vendor.Vendors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Vendor vendor)
        {
            Vendor.CreateVendor(vendor);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var vendor = Vendor.GetVendorById(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }

        [HttpGet]
        public IActionResult CreateOrder(int vendorId)
        {
            var vendor = Vendor.GetVendorById(vendorId);
            if (vendor == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(int vendorId, Order order)
        {
            try
            {
                Order.CreateOrderForVendor(vendorId, order);
                return RedirectToAction("Details", new { id = vendorId });
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View();
            }
        }
    }
}
