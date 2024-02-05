using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
    public class VendorTests
    {
      [TestMethod]
      public void VendorInitialization()
      {
        string vendorName = "Suzie's Cafe";
        string vendorDescription = "A cozy cafe with delicious treats.";

        var vendor = new Vendor { Name = vendorName, Description = vendorDescription };

        Assert.AreEqual(vendorName, vendor.Name);
        Assert.AreEqual(vendorDescription, vendor.Description);
        CollectionAssert.IsEmpty(vendor.Orders);
      }
    }
}