using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Webshop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;

namespace MVC_Webshop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //DBSets
        public DbSet<ApplicationUser> Users { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Shipment> Shipments { get; set; } = default!;
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } = default!;
        public DbSet<Stock> Stocks { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

            string adminId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();
            string managerId = Guid.NewGuid().ToString();


            //modelbuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            //{
            //    FirstName = "Torkel",
            //    Id = adminId,
            //    Email = "Admin",
            //});

            //modelbuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            //{
            //    FirstName = "Gerpgork",
            //    Id = userId,
            //    Email = "User",
            //});

            //modelbuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            //{
            //    FirstName = "Urban",
            //    Id = managerId,
            //    Email = "Manager",
            //});

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = adminId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = userId,
                Name = "User",
                NormalizedName = "USER"

            });
            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
               Id = managerId,
               Name = "Manager",
               NormalizedName = "MANAGER"

            });

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            modelbuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "Admin",
                LastName = "Adminson",
                CreditCardNumber = "zigiplz",
                PasswordHash = passwordHasher.HashPassword(null, "password")
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminId,
                UserId = userId,
            });
        }

        public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
        {
            public void Configure(EntityTypeBuilder<ApplicationUser> modelbuilder)
            {
                modelbuilder.Property(u => u.FirstName).HasMaxLength(255);
                modelbuilder.Property(u => u.LastName).HasMaxLength(255);
            }
            //public void Configure(EntityTypeBuilder<Product> modelbuilder)
            //{
            //    modelbuilder.Property(p => p.Price).HasColumnType("decimal");
            //}
        }
    }
}