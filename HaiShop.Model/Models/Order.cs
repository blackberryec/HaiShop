using HaiShop.Model.Abtract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace HaiShop.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [ForeignKey("ID")]
        public virtual OrderDetail OrderDetail { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessenge { set; get; }

        [Required]
        [MaxLength(256)]
        public string PaymentMethod { set; get; }

        [Required]
        public string PaymentStatus { set; get; } //có vấn đề
        public override DateTime? CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string UpdateBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}