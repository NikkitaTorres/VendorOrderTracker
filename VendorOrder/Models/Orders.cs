using System.Collections.Generic;
using System;

namespace VendorOrder.Models
{
  public class Order
  {
    public int OrderId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }
  }
}