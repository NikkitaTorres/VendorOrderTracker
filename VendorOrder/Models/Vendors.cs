using System.Collections.Generic;

namespace VendorOrder.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public static List<Vendor> Vendors { get; } = new List<Vendor>();

        public Vendor()
        {
            Orders = new List<Order>();
        }

        public static void CreateVendor(Vendor vendor)
        {
            vendor.VendorId = Vendors.Count + 1;
            Vendors.Add(vendor);
        }

        public static Vendor GetVendorById(int id)
        {
            return Vendors.Find(vendor => vendor.VendorId == id);
        }

        public void AddOrder(Order order)
        {
            order.OrderId = Orders.Count + 1;
            Orders.Add(order);
        }
    }
}
