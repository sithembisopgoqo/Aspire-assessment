using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ISBank_Assessment.BE
{
    public class LoanEntity
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        public string CustomerName { get; set; }
        public int NumberOfPayments { get; set; }
        public int NumberOfYears { get; set; }
        public double MonthlyPayments { get; set; }

        ////ECC/ END CUSTOM CODE SECTION 

        public int LoanId { get; set; }
        public decimal Amount { get; set; }
        public decimal IntrestRate { get; set; }
        public int RepaymentTerms { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public int CustomerId { get; set; }
      
    }

    public class LoanEntityMapper : MapperBase<Loan, LoanEntity>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 

        public override Expression<Func<Loan, LoanEntity>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<Loan, LoanEntity>>)(p => new LoanEntity()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    LoanId = p.LoanId,
                    Amount = p.Amount,
                    IntrestRate = p.IntrestRate,
                    RepaymentTerms = p.RepaymentTerms,
                    DateCreated = p.DateCreated,
                    CreatedBy=p.CreatedBy,
                    CustomerId=p.CustomerId,

                }));
            }
        }

        public override void MapToModel(LoanEntity dto, Loan model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.LoanId = dto.LoanId;
            model.Amount = dto.Amount;
            model.IntrestRate = dto.IntrestRate;
            model.RepaymentTerms = dto.RepaymentTerms;
            model.DateCreated = dto.DateCreated;
            model.CreatedBy = dto.CreatedBy;
            model.CustomerId = dto.CustomerId;

        }
    }
}
