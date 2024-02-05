using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
    public void VendorInitialization()
    {
        // Arrange
        string vendorName = "Suzie's Cafe";
        string vendorDescription = "A cozy cafe with delicious treats.";

        // Act
        var vendor = new Vendor { Name = vendorName, Description = vendorDescription };

        // Assert
        Assert.Equal(vendorName, vendor.Name);
        Assert.Equal(vendorDescription, vendor.Description);
        Assert.Empty(vendor.Orders); // Ensure Orders list is initialized and empty.
    }
}