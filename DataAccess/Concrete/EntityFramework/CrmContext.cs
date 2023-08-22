//burası komple iptal 

//using Core.Concrete;
//using Entities.Concrete;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using WebAPI.Models;

//namespace DataAccess.Concrete.EntityFramework
//{
//    public class CrmContext : DbContext
//    {
//        /// bunu niye yazdım bende bilmiyorum
//        //public CrmContext()
//        //{
//        //}
//        //public CrmContext(DbContextOptions<CrmContext> options) : base(options)
//        //{
//        //}
//        ///
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-UGD7FQ4\SQLEXPRESS;Database=CustomerRelationshipManagement;User ID = DESKTOP-UGD7FQ4\zeyno;Password="" ");
//            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-UGD7FQ4\SQLEXPRESS;Database=CustomerRelationshipManagement;User ID = DESKTOP-UGD7FQ4\zeyno;Password="";Trusted_Connection=true");
//            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UGD7FQ4\SQLEXPRESS;Database=CustomerRelationshipManagement;Trusted_Connection=true;Encrypt=False");
//        }
//        public DbSet<Cities> Cities { get; set; }
//        public DbSet<CommunicationTypes> CommunicationTypes { get; set; }
//        public DbSet<Countries> Countries { get; set; }
//        public DbSet<CustomerCommunicationLog> CustomerCommunicationLog { get; set; }
//        public DbSet<Customers> Customers { get; set; }
//        public DbSet<CustomersEmployees> Customers_Employees { get; set; }
//        public DbSet<Departments> Departments { get; set; }
//        public DbSet<Employees> Employees { get; set; }
//        public DbSet<Offerings> Offerings { get; set; }
//        public DbSet<Permissions> Permissions { get; set; }
//        public DbSet<ProductCategories> ProductCategories { get; set; }
//        public DbSet<Products> Products { get; set; }
//        public DbSet<ProductsProductCategories> Products_ProductCategoriesings { get; set; }
//        public DbSet<Prospects> Prospects { get; set; }
//        public DbSet<ProspectsCustomers> Prospects_Customers { get; set; }
//        public DbSet<ProspectsCommunicationLog> ProspectsCommunicationLog { get; set; }
//        public DbSet<CommunicationReport> CommunicationReport { get; set; }
//        public DbSet<CustomerReport> CustomerReport { get; set; }
//        public DbSet<OfferReport> OfferReport { get; set; }
//        public DbSet<FinancialReport> FinancialReport { get; set; }
//        public DbSet<SalesPerformanceReport> SalesPerformanceReport { get; set; }
//        public DbSet<StockReport> StockReport { get; set; }
//        public DbSet<Roles> Roles { get; set; }
//        public DbSet<RolesPermissions> Roles_Permissions { get; set; }
//        public DbSet<Sales> Sales { get; set; }
//        public DbSet<SalesDetails> SalesDetails { get; set; }
//        public DbSet<SalesOpportunities> SalesOpportunities { get; set; }
//        public DbSet<SalesOpportunitiesOfferings> SalesOpportunities_Offerings { get; set; }
//        public DbSet<SalesStatus> SalesStatus { get; set; }
//        public DbSet<UsersDepartments> Users_Departments { get; set; }
//        public DbSet<UsersRoles> Users_Roles { get; set; }
//        //public DbSet<Users> Users { get; set; }
//        public DbSet<Users> Users { get; set; }
//        public DbSet<OperationClaim> OperationClaims { get; set; }
//        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

//        //public DbSet<Users> Users { get; set; }
//        //public DbSet<OperationClaim> OperationClaims { get; set; }
//        //public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

//        //public DbSet<OperationClaim> OperationClaims { get; set; }  
//        //public DbSet<UserOperationClaim> UserOperationCaims { get; set; }

//        //protected override void OnModelCreating(ModelBuilder modelBuilder)
//        //{
//        //    modelBuilder.Entity<Users>(entity =>
//        //    {

//        //        entity.HasKey(e => e.Id).HasName("PK_Users");
//        //        entity.Property(e => e.Id).UseIdentityColumn();
//        //        entity.Property(e => e.Name);
//        //        entity.Property(e => e.Surname);
//        //        entity.Property(e => e.Email);
//        //        entity.Property(e => e.UserName);
//        //    });
//        //}

//    }
//}
