using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ISBank_Assessment.BE
{
    public class EmploymentDetailsEntity
    {
        public int EmploymentDetailsId { get; set; }
        public string Income { get; set; }
        public string Job { get; set; }
        public string Title { get; set; }
        public string Employer { get; set; }
        public Nullable<int> CustomerContactId { get; set; }
    }

    public class EmploymentDetailsEntityMapper : MapperBase<EmploymentDetail, EmploymentDetailsEntity>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public override Expression<Func<EmploymentDetail, EmploymentDetailsEntity>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<EmploymentDetail, EmploymentDetailsEntity>>)(p => new EmploymentDetailsEntity()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    EmploymentDetailsId = p.EmploymentDetailsId,
                    Income = p.Income,
                    Job = p.Job,
                    Title = p.Title,
                    Employer = p.Employer,
                    CustomerContactId = p.CustomerContactId,
                  
                }));
            }
        }

        public override void MapToModel(EmploymentDetailsEntity dto, EmploymentDetail model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.EmploymentDetailsId = dto.EmploymentDetailsId;
            model.Income = dto.Income;
            model.Job = dto.Job;
            model.Title = dto.Title;
            model.Employer = dto.Employer;
            model.CustomerContactId = dto.CustomerContactId;


        }
    }
}
