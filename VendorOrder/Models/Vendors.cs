using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public int VendorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>();
  }
}