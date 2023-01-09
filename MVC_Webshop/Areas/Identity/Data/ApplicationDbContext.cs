using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Webshop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;
using System.Reflection.Emit;
using System;

namespace MVC_Webshop.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //DBSets
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } = default!;
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;



        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

            string adminId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();
            string managerId = Guid.NewGuid().ToString();

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


            // Shopping Cart Seeding
            modelbuilder.Entity<ShoppingCart>().HasData(new ShoppingCart
            {
                ShoppingCartId = userId,
                UserId = userId,
                ShoppingCartItemQuantity = 1,
            });
            modelbuilder.Entity<ShoppingCartItem>().HasData(new ShoppingCartItem
            {
                ShoppingCartId = userId,
                ProductId = userId,
                ShoppingCartItemId = userId
            });

            Random rando = new Random();
            var number = rando.Next(1, 5);
            modelbuilder.Entity<Order>().HasData(new Order
            {
                OrderId = userId,
                UserId = userId,
                ShippingDate = DateTime.Now,
                ExpectedDelivery = rando.ToString(),
                Shipped = false,
                ProductId = userId,
                OrderDate = DateTime.Now,
            });

            modelbuilder.Entity<Product>().HasData(new Product
            {
                Id = userId,
                Name = "Gerpgork",
                Brand = "Birdstuff",
                Price = 2000,
                Description = "it's a type of bird",
                ShortDescription = "tb",
                Quantity = 1,
                CategoryId = userId
            });

            modelbuilder.Entity<Category>().HasData(new Category
            {
                Id = userId,
                ProductId = userId,
                Name = "Birds",

            });

            modelbuilder.Entity<Category>().HasMany(p => p.Products).WithMany(c => c.Categories).UsingEntity(j => j.HasData(new { ProductsId = userId, CategoriesId = userId }
            ));
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