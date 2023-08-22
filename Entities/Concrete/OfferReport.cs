using Core.Entities;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    public partial class OfferReport : IEntity
    {
        public int Id { get; set; }
        public string SalesOpportunitiesName { get; set; }
        public decimal SalesOpportunitiesAmount { get; set; }
        public DateTime SalesOpportunitiesStartDate { get; set; }
        public DateTime SalesOpportunitiesEndDate { get; set; }
        public bool SalesOpportunitiesStatus { get; set; }
        public string OfferName { get; set; }
        public decimal OfferAmount { get; set; }
        public DateTime OfferValidDate { get; set; }
        public string OfferDescription { get; set; }
        public string SalesStatusStatus { get; set; }
        public string SalesStatusNotes { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
