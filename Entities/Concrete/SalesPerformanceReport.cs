using Core.Entities;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    public partial class SalesPerformanceReport : IEntity
    {
        public int Id { get; set; }
        public int CitiesId { get; set; }
        public int CountriesId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public decimal SalesTotalPrice { get; set; }
        public DateTime SalesDate { get; set; }
        public int SalesQuantity { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmployeePhoneNumber { get; set; }
        public int EmployeeIdentificationNumber { get; set; }
        public DateTime EmployeeBirthDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerCompanyAddress { get; set; }
        public int CustomerCompanyPhone { get; set; }
        public string ProspectName { get; set; }
        public string ProspectSurname { get; set; }
        public string ProspectEmail { get; set; }
        public int ProspectPhoneNumber { get; set; }
        public string ProspectCompanyName { get; set; }
        public string ProspectAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Cities Cities { get; set; }
        public virtual Countries Countries { get; set; }
    }
}
