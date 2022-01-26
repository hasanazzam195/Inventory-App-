using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InventoryDataAccess.Entity
{
    [Table("Orders")]
    public class Order
    {
        public int ID { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_Phone { get; set; }
        [ForeignKey("product")]
        public int product_id { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public double GrossAmount { get; set; }
        public double VAT { get; set; }
        public double Discount { get; set; }
        public double Net_Amount { get; set; }
        public string status { get; set; }
        public DateTime Order_Date { get; set; }

        public Product product { get; set; }


    }
}
