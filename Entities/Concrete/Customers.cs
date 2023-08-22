using Core.Entities;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    public partial class Customers : IEntity
    {
        public Customers()
        {
            CustomerCommunicationLog = new HashSet<CustomerCommunicationLog>();
            CustomersEmployees = new HashSet<CustomersEmployees>();
            ProspectsCustomers = new HashSet<ProspectsCustomers>();
            Sales = new HashSet<Sales>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public int CompanyPhone { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Cities City { get; set; }
        public virtual Countries Country { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CustomerCommunicationLog> CustomerCommunicationLog { get; set; }
        public virtual ICollection<CustomersEmployees> CustomersEmployees { get; set; }
        public virtual ICollection<ProspectsCustomers> ProspectsCustomers { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
