using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Alexia_Mircea_ProiectFinal.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public ICollection<Clothing>? Clothes { get; set; }
    }
}
