using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Security.Policy;

namespace Alexia_Mircea_ProiectFinal.Models
{
    public class Clothing
    {
        public int ID { get; set; }
        [Display(Name = "Product Code")]
        public int ItemID { get; set; }
        [Display(Name = "Item")]
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public int? CategoryID { get; set; }
        [Display(Name = "Category Name")]
        public Category? Category { get; set; }
    }
}
