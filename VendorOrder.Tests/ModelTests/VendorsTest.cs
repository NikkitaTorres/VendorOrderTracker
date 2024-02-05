using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
    [TestClass]
    public class VendorsTests
    {
        [TestMethod]
        public void VendorInitialization()
        {
            string vendorName = "Suzie's Cafe";
            string vendorDescription = "A cozy cafe with delicious treats.";

            var vendor = new Vendor { Name = vendorName, Description = vendorDescription };

            Assert.AreEqual(vendorName, vendor.Name);
            Assert.AreEqual(vendorDescription, vendor.Description);
            CollectionAssert.AreEqual(new List<Order>(), vendor.Orders);
        }

        [TestMethod]
        public void VendorAddOrder()
        {
            var vendor = new Vendor();
            var order = new Order();

            vendor.Orders.Add(order);

            Assert.AreEqual(1, vendor.Orders.Count);
            CollectionAssert.Contains(vendor.Orders, order);
        }
    }
}