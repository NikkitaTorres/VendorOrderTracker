using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderInitialization()
    {
      string orderTitle = "Croissants";
      string orderDescription = "Freshly baked croissants for Suzie's Cafe";
      decimal orderPrice = 12.99m;
      DateTime orderDate = DateTime.Now;

      var order = new Order
      {
        Title = orderTitle,
        Description = orderDescription,
        Price = orderPrice,
        Date = orderDate
      };

      Assert.AreEqual(orderTitle, order.Title);
      Assert.AreEqual(orderDescription, order.Description);
      Assert.AreEqual(orderPrice, order.Price);
      Assert.AreEqual(orderDate, order.Date);
    }

    [TestMethod]
        public void CreateOrderForVendor_AddsNewOrderToVendor()
        {
            var vendor = new Vendor { Name = "Test Vendor", Description = "Test Description" };
            Vendor.CreateVendor(vendor);
            var order = new Order { Title = "Test Order", Description = "Test Description", Price = 10 };

            Order.CreateOrderForVendor(vendor.VendorId, order);
            
            CollectionAssert.Contains(vendor.Orders, order);
        }
  }
}