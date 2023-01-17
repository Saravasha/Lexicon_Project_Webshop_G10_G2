
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Webshop.Areas.Identity.Data;
using MVC_Webshop.Models;
using MVC_Webshop.ViewModels;

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
        public DbSet<Cart> Carts { get; set; } = default!;
        public DbSet<Item> Items { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;

        public DbSet<ApplicationUserViewModel> Users { get; set; } = default!;

        public DbSet<ApplicationRoleViewModel> Roles { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            //modelbuilder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

            string adminId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();
            string managerId = Guid.NewGuid().ToString();

            Random rando = new Random();
            var number = rando.Next(1, 5).ToString();

            // Product
            modelbuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Gerpgork", Brand = "Birdstuff", Price = 2000, Description = "it's a type of bird", ShortDescription = "tb", ImageUrl = "/img/gerpgork.jpg", Quantity = 1, CategoryId = 1, });
            modelbuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Banana", Brand = "Chiquita", Price = 5, Description = "it's a type of Banana", ShortDescription = "tb", ImageUrl = "/img/Banana.jpg", Quantity = 1, CategoryId = 2 });
            modelbuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Volvo XC70", Brand = "Volvo", Price = 500000, Description = "it's a type of car", ShortDescription = "tb", ImageUrl = "/img/Volvo.jpg", Quantity = 1, CategoryId = 3 });

            // Category
            modelbuilder.Entity<Category>().HasData(new Category { Id = 1, ProductId = 1, Name = "Birds", });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 2, ProductId = 2, Name = "Fruit", });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 3, ProductId = 3, Name = "Bilar", });

            // Order
            modelbuilder.Entity<Order>().HasData(new Order { Id = 1, ShippingDate = DateTime.Now, ExpectedDelivery = number, Shipped = false, OrderDate = DateTime.Now });
            modelbuilder.Entity<Order>().HasData(new Order { Id = 2, ShippingDate = DateTime.Now, ExpectedDelivery = number, Shipped = false, OrderDate = DateTime.Now });

            // Cart
            modelbuilder.Entity<Cart>().HasData(new Cart { Id = 1 });
            modelbuilder.Entity<Cart>().HasData(new Cart { Id = 2 });

            // Item
            modelbuilder.Entity<Item>().HasData(new Item { Id = 1, CartId = 1, ProductIdRef = 1, Quantity = 1, });
            //modelbuilder.Entity<Item>().HasData(new Item { Id = 2, CartId = 2, ProductIdRef = 2, Quantity = 2, });

            // Join Fluent API
            modelbuilder.Entity<Product>().HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity(j => j.HasData(new { CategoriesId = 1, ProductsId = 1 }
                ));

            //modelbuilder.Entity<Cart>().HasMany(t => t.Items);

            // Identity Roles

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

            modelbuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = userId,
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    FirstName = "Admin",
                    LastName = "Adminson",
                    CreditCardNumber = "234",
                    CartId = 1,
                    OrderId = 1,
                    PasswordHash = passwordHasher.HashPassword(null, "password")
                },

                new ApplicationUser
                {
                    Id = managerId,
                    Email = "karen@manager.com",
                    NormalizedEmail = "KAREN@MANAGER.COM",
                    UserName = "Karen",
                    NormalizedUserName = "KAREN",
                    FirstName = "Karen",
                    LastName = "Managerson",
                    CreditCardNumber = "123",
                    CartId = 2,
                    OrderId = 2,
                    PasswordHash = passwordHasher.HashPassword(null, "password")
                }
            );

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminId,
                    UserId = userId,
                },
                new IdentityUserRole<string>
                {
                    RoleId = managerId,
                    UserId = userId
                }
            );
        }
    }
}