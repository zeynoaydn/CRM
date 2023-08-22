using Core.Entities;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    public partial class SalesOpportunities : IEntity
    {
        public SalesOpportunities()
        {
            SalesOpportunitiesOfferings = new HashSet<SalesOpportunitiesOfferings>();
            SalesStatus = new HashSet<SalesStatus>();
        }

        public int Id { get; set; }
        public int ProspectId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Prospects Prospect { get; set; }
        public virtual ICollection<SalesOpportunitiesOfferings> SalesOpportunitiesOfferings { get; set; }
        public virtual ICollection<SalesStatus> SalesStatus { get; set; }
    }
}
