//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISBank_Assessment.BE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int code { get; set; }
        public int account_code { get; set; }
        public System.DateTime transaction_date { get; set; }
        public System.DateTime capture_date { get; set; }
        public decimal amount { get; set; }
        public string description { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
