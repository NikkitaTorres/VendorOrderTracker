using System;
using System.ComponentModel.DataAnnotations;

namespace VendorOrder.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid positive price")]
        public decimal Price { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
