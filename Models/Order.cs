using Microsoft.CodeAnalysis.Differencing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Alexia_Mircea_ProiectFinal.Models
{
    public class Order
    {
        public int ID { get; set; }
        [Display(Name = "Name")]
        public string ClientName { get; set; }
        [Display(Name = "Product Code")]
        public int OrderID { get; set; }
        public string Address { get; set; }
        [Display(Name = "Delivered")]
        public bool IsShipped { get; set; }
        public Clothing? Clothing { get; set; }
    }
}
