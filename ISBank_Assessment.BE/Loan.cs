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
    
    public partial class Loan
    {
        public int LoanId { get; set; }
        public decimal Amount { get; set; }
        public decimal IntrestRate { get; set; }
        public int RepaymentTerms { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public int CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}