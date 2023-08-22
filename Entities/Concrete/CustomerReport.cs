using Core.Entities;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    public partial class CustomerReport : IEntity
    {
        public int Id { get; set; }
        public int CitiesId { get; set; }
        public int CountryId { get; set; }
        public int SalesId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerCompanyAddress { get; set; }
        public int CustomerCompanyPhoneNumber { get; set; }
        public string ProspectName { get; set; }
        public string ProspectSurname { get; set; }
        public string ProspectEmail { get; set; }
        public int ProspectPhoneNumber { get; set; }
        public string ProspectCompanyName { get; set; }
        public string ProspectAddress { get; set; }
        public string OfferName { get; set; }
        public decimal OfferAmount { get; set; }
        public DateTime OfferValidDate { get; set; }
        public string OfferDescription { get; set; }
        public string SalesOpportunitiesName { get; set; }
        public decimal SalesOpportunitiesAmount { get; set; }
        public DateTime SalesOpportunitiesStartDate { get; set; }
        public DateTime SalesOpportunitiesEndDate { get; set; }
        public bool SalesOpportunitiesStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Cities Cities { get; set; }
        public virtual Countries Country { get; set; }
    }
}
