using AutoMapper;
using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Dtos
{
    public class ProductsDto : IDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfProduct { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ProductsDto> Productses { get; set; }
        //public virtual ICollection<ProductsProductCategories> ProductsProductCategories { get; set; }
        //public virtual ICollection<SalesDetails> SalesDetails { get; set; }

    }
}
