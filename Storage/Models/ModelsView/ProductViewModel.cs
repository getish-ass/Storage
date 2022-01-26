using System.ComponentModel;

namespace Storage.Models.ModelsView
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [DisplayName("Item Name")]
        public string Name { get; set; }
        public int Price { get; set; }

        public int Count { get; set; }
        public int InventoryValue { get; set; }
    }
}
