using Core.Entities;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    public partial class CommunicationReport : IEntity
    {
        public int Id { get; set; }
        public int CommunicationLogId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerCompanyName { get; set; }
        public string CustomerCompanyAddress { get; set; }
        public int CustomerCompanyPhoneNumber { get; set; }
        public string ProspectsName { get; set; }
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
    }
}
