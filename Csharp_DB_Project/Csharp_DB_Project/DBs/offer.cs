//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Csharp_DB_Project.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class offer
    {
        public int offerID { get; set; }
        public Nullable<int> offeringUserID { get; set; }
        public Nullable<int> sellerUserID { get; set; }
        public Nullable<int> stockID { get; set; }
        public decimal offerAmount { get; set; }
        public string offerStatus { get; set; }
    
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
        public virtual stockListing stockListing { get; set; }
    }
}