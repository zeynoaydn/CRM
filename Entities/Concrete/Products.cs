using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Entities.Concrete
{
    [Table("Products", Schema = "Product")]
    public partial class Products : IEntity
    {
        public Products()
        {
            ProductsProductCategories = new HashSet<ProductsProductCategories>();
            SalesDetails = new HashSet<SalesDetails>();
        }

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

        public virtual ICollection<ProductsProductCategories> ProductsProductCategories { get; set; }
        public virtual ICollection<SalesDetails> SalesDetails { get; set; }

        
        //public class ProductRepository
        //{
        //    IDataResult<List<Products>> GetAll();
        //    IDataResult<Products> GetById(int productId);
        //    IResult Add(Products products);
        //    IResult Delete(Products products);
        //    IResult Update(Products products);
        //}
    }
}
