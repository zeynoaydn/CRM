using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataAccess.Concrete.EntityFramework
{
    public partial class CustomerRelationshipManagementContext : DbContext
    {
        public CustomerRelationshipManagementContext()
        {
        }

        public CustomerRelationshipManagementContext(DbContextOptions<CustomerRelationshipManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<CommunicationReport> CommunicationReport { get; set; }
        public virtual DbSet<CommunicationTypes> CommunicationTypes { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CustomerCommunicationLog> CustomerCommunicationLog { get; set; }
        public virtual DbSet<CustomerReport> CustomerReport { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomersEmployees> CustomersEmployees { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<FinancialReport> FinancialReport { get; set; }
        public virtual DbSet<OfferReport> OfferReport { get; set; }
        public virtual DbSet<Offerings> Offerings { get; set; }
        //public virtual DbSet<OperationClaims> OperationClaims { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<ProductCategories> ProductCategories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsProductCategories> ProductsProductCategories { get; set; }
        public virtual DbSet<Prospects> Prospects { get; set; }
        public virtual DbSet<ProspectsCommunicationLog> ProspectsCommunicationLog { get; set; }
        public virtual DbSet<ProspectsCustomers> ProspectsCustomers { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesPermissions> RolesPermissions { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<SalesDetails> SalesDetails { get; set; }
        public virtual DbSet<SalesOpportunities> SalesOpportunities { get; set; }
        public virtual DbSet<SalesOpportunitiesOfferings> SalesOpportunitiesOfferings { get; set; }
        public virtual DbSet<SalesPerformanceReport> SalesPerformanceReport { get; set; }
        public virtual DbSet<SalesStatus> SalesStatus { get; set; }
        public virtual DbSet<StockReport> StockReport { get; set; }
        //public virtual DbSet<UserOperationClaims> UserOperationClaims { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersDepartments> UsersDepartments { get; set; }
        public virtual DbSet<UsersRoles> UsersRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-UGD7FQ4\\SQLEXPRESS;Database=CustomerRelationshipManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>(entity =>
            {
                entity.ToTable("Cities", "City");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cities_Countries");
            });

            modelBuilder.Entity<CommunicationReport>(entity =>
            {
                entity.ToTable("CommunicationReport", "Report");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompanyAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerSurname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProspectAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectCompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProspectEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectSurname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProspectsName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommunicationTypes>(entity =>
            {
                entity.ToTable("CommunicationTypes", "Communication");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToTable("Countries", "Country");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerCommunicationLog>(entity =>
            {
                entity.ToTable("CustomerCommunicationLog", "Customer");

                entity.Property(e => e.CommunicationDate).HasColumnType("datetime");

                entity.Property(e => e.CommunicationDetails)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CommunicationType)
                    .WithMany(p => p.CustomerCommunicationLog)
                    .HasForeignKey(d => d.CommunicationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerCommunicationLog_CommunicationType");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCommunicationLog)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerCommunicationLog_Customers");
            });

            modelBuilder.Entity<CustomerReport>(entity =>
            {
                entity.ToTable("CustomerReport", "Report");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompanyAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerSurname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfferAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OfferDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfferName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfferValidDate).HasColumnType("datetime");

                entity.Property(e => e.ProspectAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectCompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProspectEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProspectSurname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesOpportunitiesAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SalesOpportunitiesEndDate).HasColumnType("date");

                entity.Property(e => e.SalesOpportunitiesName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesOpportunitiesStartDate).HasColumnType("date");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cities)
                    .WithMany(p => p.CustomerReport)
                    .HasForeignKey(d => d.CitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerReport_Cities");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CustomerReport)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerReport_Countries");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.ToTable("Customers", "Customer");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Cities");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Countries");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Users");
            });

            modelBuilder.Entity<CustomersEmployees>(entity =>
            {
                entity.ToTable("Customers_Employees", "Customer");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomersEmployees)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Employee_Customers");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CustomersEmployees)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Employee_Employees");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.ToTable("Departments", "Department");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.ToTable("Employees", "Employee");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Users");
            });

            modelBuilder.Entity<FinancialReport>(entity =>
            {
                entity.ToTable("FinancialReport", "Report");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SalesTotalPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OfferReport>(entity =>
            {
                entity.ToTable("OfferReport", "Report");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OfferAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OfferDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfferName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfferValidDate).HasColumnType("datetime");

                entity.Property(e => e.SalesOpportunitiesAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SalesOpportunitiesEndDate).HasColumnType("date");

                entity.Property(e => e.SalesOpportunitiesName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesOpportunitiesStartDate).HasColumnType("date");

                entity.Property(e => e.SalesStatusNotes)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SalesStatusStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Offerings>(entity =>
            {
                entity.ToTable("Offerings", "Offer");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.ValidDate).HasColumnType("datetime");
            });

            //modelBuilder.Entity<OperationClaims>(entity =>
            //{
            //    entity.ToTable("OperationClaims", "OperationClaim");

            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.Property(e => e.Name).HasMaxLength(50);
            //});

            modelBuilder.Entity<Permissions>(entity =>
            {
                entity.ToTable("Permissions", "Permission");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductCategories>(entity =>
            {
                entity.ToTable("ProductCategories", "Product");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("Products", "Product");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductsProductCategories>(entity =>
            {
                entity.ToTable("Products_ProductCategories", "Product");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.ProductsProductCategories)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductCategory_ProductCategory");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductsProductCategories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductCategory_Products");
            });

            modelBuilder.Entity<Prospects>(entity =>
            {
                entity.ToTable("Prospects", "Prospect");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Prospects)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prospects_Cities");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Prospects)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prospects_Countries");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Prospects)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prospects_Users");
            });

            modelBuilder.Entity<ProspectsCommunicationLog>(entity =>
            {
                entity.ToTable("ProspectsCommunicationLog", "Prospect");

                entity.Property(e => e.CommunicationDate).HasColumnType("datetime");

                entity.Property(e => e.CommunicationDetails)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CommunicationType)
                    .WithMany(p => p.ProspectsCommunicationLog)
                    .HasForeignKey(d => d.CommunicationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommunicationLog_CommunicationType");

                entity.HasOne(d => d.Prospect)
                    .WithMany(p => p.ProspectsCommunicationLog)
                    .HasForeignKey(d => d.ProspectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProspectsCommunicationLog_Prospects");
            });

            modelBuilder.Entity<ProspectsCustomers>(entity =>
            {
                entity.ToTable("Prospects_Customers", "Prospect");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProspectsCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prospect_Customer_Customers");

                entity.HasOne(d => d.Prospects)
                    .WithMany(p => p.ProspectsCustomers)
                    .HasForeignKey(d => d.ProspectsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prospect_Customer_Prospects");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("Roles", "Role");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RolesPermissions>(entity =>
            {
                entity.ToTable("Roles_Permissions", "Role");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolesPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Permission_Permissions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolesPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Permission_Roles");
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.ToTable("Sales", "Sales");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_Customers");
            });

            modelBuilder.Entity<SalesDetails>(entity =>
            {
                entity.ToTable("SalesDetails", "Sales");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SalesDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleDetails_Products");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.SalesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SaleDetails_Sales");
            });

            modelBuilder.Entity<SalesOpportunities>(entity =>
            {
                entity.ToTable("SalesOpportunities", "Sales");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Prospect)
                    .WithMany(p => p.SalesOpportunities)
                    .HasForeignKey(d => d.ProspectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOpportunities_Prospects");
            });

            modelBuilder.Entity<SalesOpportunitiesOfferings>(entity =>
            {
                entity.ToTable("SalesOpportunities_Offerings", "Sales");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.SalesOpportunitiesOfferings)
                    .HasForeignKey(d => d.OfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOpportunities_Offer_Offerings");

                entity.HasOne(d => d.SalesOpportunities)
                    .WithMany(p => p.SalesOpportunitiesOfferings)
                    .HasForeignKey(d => d.SalesOpportunitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesOpportunities_Offer_SalesOpportunities");
            });

            modelBuilder.Entity<SalesPerformanceReport>(entity =>
            {
                entity.ToTable("SalesPerformanceReport", "Report");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompanyAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerSurname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeBirthDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeSurname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProspectAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectCompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProspectEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProspectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProspectSurname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesDate).HasColumnType("datetime");

                entity.Property(e => e.SalesTotalPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cities)
                    .WithMany(p => p.SalesPerformanceReport)
                    .HasForeignKey(d => d.CitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPerformanceReport_Cities");

                entity.HasOne(d => d.Countries)
                    .WithMany(p => p.SalesPerformanceReport)
                    .HasForeignKey(d => d.CountriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesPerformanceReport_Countries");
            });

            modelBuilder.Entity<SalesStatus>(entity =>
            {
                entity.ToTable("SalesStatus", "Sales");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SalesOpportunities)
                    .WithMany(p => p.SalesStatus)
                    .HasForeignKey(d => d.SalesOpportunitiesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesStatus_SalesOpportunities");
            });

            modelBuilder.Entity<StockReport>(entity =>
            {
                entity.ToTable("StockReport", "Report");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            //modelBuilder.Entity<UserOperationClaims>(entity =>
            //{
            //    entity.ToTable("UserOperationClaims", "UserOperationClaim");

            //    entity.Property(e => e.Id).ValueGeneratedNever();
            //});

            modelBuilder.Entity<Entities.Concrete.Users>(entity =>
            {
                entity.ToTable("Users", "User");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UsersDepartments>(entity =>
            {
                entity.ToTable("Users_Departments", "User");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.UsersDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Department_Departments");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersDepartments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Department_Users");
            });

            modelBuilder.Entity<UsersRoles>(entity =>
            {
                entity.ToTable("Users_Roles", "User");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsersRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role_Users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
