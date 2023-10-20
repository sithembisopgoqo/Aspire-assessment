using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ISBank_Assessment.BE
{
    public class CustomerContactEntity
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public int CustomerContactId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public string FunctionalArea { get; set; }
        public string MobileNumber { get; set; }
        public string OfficeNumber { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Comments { get; set; }
        public int CustomerId { get; set; }
        public bool isPrimary { get; set; }
    }

    public class CustomerContactEntityMapper : MapperBase<CustomerContact, CustomerContactEntity>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public override Expression<Func<CustomerContact, CustomerContactEntity>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<CustomerContact, CustomerContactEntity>>)(p => new CustomerContactEntity()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    CustomerContactId = p.CustomerContactId,
                    FirstName = p.FirstName,
                    Surname = p.Surname,
                    JobTitle = p.JobTitle,
                    FunctionalArea = p.FunctionalArea,
                    MobileNumber = p.MobileNumber,
                    OfficeNumber = p.OfficeNumber,
                    Email = p.Email,
                    Birthday = p.Birthday,
                    Comments = p.Comments,
                    CustomerId = p.CustomerId,
                    isPrimary = p.isPrimary
                }));
            }
        }

        public override void MapToModel(CustomerContactEntity dto, CustomerContact model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.CustomerContactId = dto.CustomerContactId;
            model.FirstName = dto.FirstName;
            model.Surname = dto.Surname;
            model.JobTitle = dto.JobTitle;
            model.FunctionalArea = dto.FunctionalArea;
            model.MobileNumber = dto.MobileNumber;
            model.OfficeNumber = dto.OfficeNumber;
            model.Email = dto.Email;
            model.Birthday = dto.Birthday;
            model.Comments = dto.Comments;
            model.CustomerId = dto.CustomerId;
            model.isPrimary = dto.isPrimary;

        }
    }
}
