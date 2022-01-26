using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entity
{
    [Table("Products")]
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SKU { get; set; }
        public double price { get; set; }
        public int QTY { get; set; }
        public string description { get; set; }
        public string Image_Path { get; set; }
        [ForeignKey("Color")]
        public int Color_id { get; set; }
        [ForeignKey("Size")]
        public int Size_id { get; set; }
        [ForeignKey("brand")]
        public int Brand_id { get; set; }
        [ForeignKey("category")]
        public int Category_id { get; set; }
        [ForeignKey("store")]
        public int Store_id { get; set; }
        public string Status { get; set; }

        public AttributeValue Size { get; set; }
        public AttributeValue Color { get; set; }
        public Brand brand { get; set; }
        public Category category { get; set; }
        public store store { get; set; }
        public List<Order> liOrder { get; set; }

    }
}
