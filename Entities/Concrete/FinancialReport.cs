using Core.Entities;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    public partial class FinancialReport : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int NumberOfProduct { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public decimal SalesTotalPrice { get; set; }
        public int SalesQuantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
