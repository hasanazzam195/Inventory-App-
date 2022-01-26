using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entity
{
    [Table("Attribute_Values")]
    public class AttributeValue
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [ForeignKey("attributes")]
        public int Attribute_id { get; set; }
        public Attributes attributes { get; set; }
        [InverseProperty("Size")]
        public List<Product> liProductSize { get; set; }
        [InverseProperty("Color")]
        public List<Product> liProductColor { get; set; }
    }
}
