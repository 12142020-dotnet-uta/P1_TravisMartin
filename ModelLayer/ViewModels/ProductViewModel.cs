using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.ViewModels
{
    public class ProductViewModel
    {
        public Guid ProductId { get; set; } = Guid.NewGuid();

        [DisplayName("PS4 Game Name")]
        public string ProductName { get; set; } // name of product
        [DisplayName("Price")]
        public double ProductPrice { get; set; } // price of product
        [DisplayName("Description")]
        public string ProductDescription { get; set; } // brief description of product
        [DisplayName("Image of Game")]
        public string JpgStringImage { get; set; }
        [DisplayName("Amount Available")]
        public int ProductQuantity { get; set; } // number of each product

        [DisplayName("How much do you want?")]
        [Range(1, 3)]
        [Required]
        public int AmountChosen { get; set; } // number of products to put in cart

    }
}
