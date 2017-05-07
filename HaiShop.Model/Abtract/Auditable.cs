using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiShop.Model.Abtract
{
    public abstract class Auditable : IAuditable
    {
        public abstract DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        public abstract string CreatedBy { get; set; }

        public abstract DateTime? UpdateDate { get; set; }

        [MaxLength(256)]
        public abstract string UpdateBy { get; set; }



        [MaxLength(256)]
        public abstract string MetaKeyword { get; set; }
        [MaxLength(256)]
        public abstract string MetaDescription { get; set; }


        public abstract bool Status { get; set; }
    }
}
