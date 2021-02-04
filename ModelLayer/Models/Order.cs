using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; } = Guid.NewGuid();

        public Guid CustomerId { get; set; }
        public Customer Customers { get; set; }

        public Guid StoreLocationId { get; set; }
        public StoreLocation StoreLocations { get; set; }

       // public string ProductName { get; set; }
        public Guid ProductId { get; set; }
        public Product Products { get; set; }
        // public ICollection<Product> Products { get; set; }

        [Display(Name = "Time Ordered")]
        public DateTime Ordertime { get; set; }

        [Display(Name = "Amount Ordered")]
        public int OrderQuantity { get; set; }

        [Display(Name = "Total Price")]
        public double TotalOrderPrice { get; set; }
    }
}
