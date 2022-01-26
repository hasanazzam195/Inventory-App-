using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entity
{
    [Table("Countries")]
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Company> licompany { get; set; }
    }
}
