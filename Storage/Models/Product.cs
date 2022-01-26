using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name="Item Name")]
        [StringLength(7, ErrorMessage ="Itemname must have max 7  letters.")]
        public string Name { get; set; }
        
        public int Price { get; set; }
        [DataType(DataType.Date)]

        public DateTime OrderDate { get; set; }
        public string Category { get; set; }
        
        public string Shelf { get; set; }
        public int Count { get; set; }
        public String Description { get; set; }

    }
}
