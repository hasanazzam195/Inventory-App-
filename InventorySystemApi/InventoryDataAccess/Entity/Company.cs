using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entity
{
    [Table("Companies")]
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double charge_Amount { get; set; }
        public double Vat_Charge { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [ForeignKey("country")]
        public int country_id { get; set; }
        [ForeignKey("currency")]
        public int currency_id { get; set; }
        public string message { get; set; }

        public Country country { get; set; }
        public Currency currency { get; set; }
    }
}
