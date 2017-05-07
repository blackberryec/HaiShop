using System;

namespace HaiShop.Model.Abtract
{
    public interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}