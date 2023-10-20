using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace ISBank_Assessment.BE
{
    public class CustomerEntity
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 
        public int CustomerId { get; set; }
        public int CustomerType { get; set; }
        public int Status { get; set; }
        public string AccountNumber { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string IDNumber { get; set; }
        public string PassportNumber { get; set; }
        public string PreferredLanguage { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string LandLineNumber { get; set; }
        public string AlternateNumber { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingAddress3 { get; set; }
        public string BillingAddress4 { get; set; }
        public string BillingPostalCode { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PhysicalAddress3 { get; set; }
        public string PhysicalAddress4 { get; set; }
        public string PhysicalPostalCode { get; set; }
        public string Region { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string CompanyDescription { get; set; }
        public string RegNumber { get; set; }
        public string VATNumber { get; set; }
        public string ExternalAccountNumber { get; set; }
        public string Remarks { get; set; }
        public string Classification { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public System.DateTime LastModifiedByDate { get; set; }
        public string PostalCode { get; set; }
        public int Code { get; set; }

    }

    public class CustomerEntityMapper : MapperBase<Customer, CustomerEntity>
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION 
        ////ECC/ END CUSTOM CODE SECTION 

        public override Expression<Func<Customer, CustomerEntity>> SelectorExpression
        {
            get
            {
                return ((Expression<Func<Customer, CustomerEntity>>)(p => new CustomerEntity()
                {
                    ////BCC/ BEGIN CUSTOM CODE SECTION 
                    ////ECC/ END CUSTOM CODE SECTION 
                    CustomerId = p.CustomerId,
                    CustomerType = p.CustomerType,
                    Status = p.Status,
                    AccountNumber = p.AccountNumber,
                    Title = p.Title,
                    FirstName = p.FirstName,
                    Surname = p.Surname,
                    IDNumber = p.IDNumber,
                    PassportNumber = p.PassportNumber,
                    PreferredLanguage = p.PreferredLanguage,
                    Email = p.Email,
                    MobileNumber = p.MobileNumber,
                    LandLineNumber = p.LandLineNumber,
                    AlternateNumber = p.AlternateNumber,
                    BillingAddress1 = p.BillingAddress1,
                    BillingAddress2 = p.BillingAddress2,
                    BillingAddress3 = p.BillingAddress3,
                    BillingAddress4 = p.BillingAddress4,
                    BillingPostalCode = p.BillingPostalCode,
                    PhysicalAddress1 = p.PhysicalAddress1,
                    PhysicalAddress2 = p.PhysicalAddress2,
                    PhysicalAddress3 = p.PhysicalAddress3,
                    PhysicalAddress4 = p.PhysicalAddress4,
                    PhysicalPostalCode = p.PhysicalPostalCode,
                    Region = p.Region,
                    CompanyName = p.CompanyName,
                    CompanyType = p.CompanyType,
                    CompanyDescription = p.CompanyDescription,
                    RegNumber = p.RegNumber,
                    VATNumber = p.VATNumber,
                    ExternalAccountNumber = p.ExternalAccountNumber,
                    Remarks = p.Remarks,
                    Classification = p.Classification,
                    CreatedBy = p.CreatedBy,
                    CreatedDate = p.CreatedDate,
                    LastModifiedBy = p.LastModifiedBy,
                    ApprovalDate = p.ApprovalDate,
                    LastModifiedByDate = p.LastModifiedByDate,
                    Code=p.Code,
           
                }));
            }
        }

        public override void MapToModel(CustomerEntity dto, Customer model)
        {
            ////BCC/ BEGIN CUSTOM CODE SECTION 
            ////ECC/ END CUSTOM CODE SECTION 
            model.CustomerId = dto.CustomerId;
            model.CustomerType = dto.CustomerType;
            model.Status = dto.Status;
            model.AccountNumber = dto.AccountNumber;
            model.Title = dto.Title;
            model.FirstName = dto.FirstName;
            model.Surname = dto.Surname;
            model.IDNumber = dto.IDNumber;
            model.PassportNumber = dto.PassportNumber;
            model.PreferredLanguage = dto.PreferredLanguage;
            model.Email = dto.Email;
            model.MobileNumber = dto.MobileNumber;
            model.LandLineNumber = dto.LandLineNumber;
            model.AlternateNumber = dto.AlternateNumber;
            model.BillingAddress1 = dto.BillingAddress1;
            model.BillingAddress2 = dto.BillingAddress2;
            model.BillingAddress3 = dto.BillingAddress3;
            model.BillingAddress4 = dto.BillingAddress4;
            model.BillingPostalCode = dto.BillingPostalCode;
            model.PhysicalAddress1 = dto.PhysicalAddress1;
            model.PhysicalAddress2 = dto.PhysicalAddress2;
            model.PhysicalAddress3 = dto.PhysicalAddress3;
            model.PhysicalAddress4 = dto.PhysicalAddress4;
            model.PhysicalPostalCode = dto.PhysicalPostalCode;
            model.Region = dto.Region;
            model.CompanyName = dto.CompanyName;
            model.CompanyType = dto.CompanyType;
            model.CompanyDescription = dto.CompanyDescription;
            model.RegNumber = dto.RegNumber;
            model.VATNumber = dto.VATNumber;
            model.ExternalAccountNumber = dto.ExternalAccountNumber;
            model.Remarks = dto.Remarks;
            model.Classification = dto.Classification;
            model.CreatedBy = dto.CreatedBy;
            model.CreatedDate = dto.CreatedDate;
            model.LastModifiedBy = dto.LastModifiedBy;
            model.ApprovalDate = dto.ApprovalDate;
            model.LastModifiedByDate = dto.LastModifiedByDate;
            model.PostalCode = dto.PostalCode;
            model.Code = dto.Code;
        }
    }
}
