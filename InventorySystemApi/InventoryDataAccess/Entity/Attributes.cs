using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entity
{
    [Table("Attributes")]
    public class Attributes
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<AttributeValue> liAttributevalue { get; set; }
    }
}
