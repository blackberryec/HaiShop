﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaiShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        [Key]
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        public int Quantity { set; get; }

        public virtual IEnumerable<Order> Orders { set; get; }
    }
}