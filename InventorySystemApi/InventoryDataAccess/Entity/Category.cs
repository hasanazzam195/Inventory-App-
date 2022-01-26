﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entity
{
    [Table("categories")]
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<Product> liProduct { get; set; }
    }
}
