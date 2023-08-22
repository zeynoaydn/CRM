﻿using Core.Entities;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    public partial class Sales : IEntity
    {
        public Sales()
        {
            SalesDetails = new HashSet<SalesDetails>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual ICollection<SalesDetails> SalesDetails { get; set; }
    }
}
