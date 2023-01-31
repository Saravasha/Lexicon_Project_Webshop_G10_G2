
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Webshop.Models;
using Microsoft.AspNetCore.Identity;
using MVC_Webshop.ViewModels;
using System;
using System.Text;

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

        public DbSet<ApplicationUser> Users { get; set; } = default!;



        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            string adminId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();
            string managerId = Guid.NewGuid().ToString();

            Random rando = new Random();
            var number = rando.Next(1, 5).ToString();

            // Category
            //modelbuilder.Entity<Category>().HasData(new Category { Id = 1, ProductId = 1, Name = "Birds", });
            //modelbuilder.Entity<Category>().HasData(new Category { Id = 2, ProductId = 2, Name = "Fruit", });
            //modelbuilder.Entity<Category>().HasData(new Category { Id = 3, ProductId = 3, Name = "Bilar", });

            modelbuilder.Entity<Category>().HasData(new Category { Id = 1,  Name = "Berry", });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 2,  Name = "Fruit", });
            modelbuilder.Entity<Category>().HasData(new Category { Id = 3,  Name = "Drinks", });

            // Product
            //modelbuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Gerpgork", Brand = "Birdstuff", Price = 2000, Description = "it's a type of bird", ShortDescription = "tb", Quantity = 1, ImageUrl = "/img/bird.jpg" });
            //modelbuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Banana", Brand = "Chiquita", Price = 5, Description = "it's a type of Banana", ShortDescription = "tb", Quantity = 1, ImageUrl = "/img/banana.jpg" });
            //modelbuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Volvo XC70", Brand = "Volvo", Price = 500000, Description = "it's a type of car", ShortDescription = "tb", Quantity = 1, ImageUrl = "/img/volvo.jpg" });

            // Fruits Products
            modelbuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Mango", Brand = "Frukt & Grönt", Price = 5, Description = "Dessa mangosar är plockade av elitpersonal djupt nere i den farliga mangodalen.", ShortDescription = "Fina mango från Mangodalen", Quantity = 200 , ImageUrl = "/imagesProduct/8fa4535c-a692-4407-83f6-e74e4dcd903b_mango-01.jpg" });

            modelbuilder.Entity<Product>().HasData(new Product { Id = 2, Name = "Citron", Brand = "Sura Gubben", Price = 4.8, Description = "Dessa citroner som odlas på hemlig utomjordisk plats har den finaste och söta surhet som någonsin uppmätts i en citron.", ShortDescription = "Färska och sura citroner", Quantity = 800, ImageUrl = "/imagesProduct/3aeac812-a431-4711-83b3-079816d8a7c1_lemon-01.jpg" });

            modelbuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Gröna äpplen", Brand = "Äppelmannen & Co", Price = 6, Description = "Dessa härliga äpplen är odlade av äppelmannen i hans trädgård. De är friska och alltid färska. Dessa bör man passa på att köpa när de finns eftersom de är svåra att få tag i när de inte finns.", ShortDescription = "Snabba äpplen med frisk smak", Quantity = 140, ImageUrl = "/imagesProduct/c8894c3b-9e69-4a34-97fd-3296ad428e49_apple-02.jpg" });

            modelbuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "Blåbär", Brand = "Mr Blueberry", Price = 0.04, Description = "Dessa bär smakar bäst efter att man mosat en näve bär i handen och sen slickar rent fingrarna..", ShortDescription = "Små runda blåa blåbär", Quantity = 1000000, ImageUrl = "/imagesProduct/4b518a1f-27a4-4ad6-8996-ce900469135b_blueberry-01.jpg" });



            // Order
            modelbuilder.Entity<Order>().HasData(new Order { Id = 1, ShippingDate = DateTime.Now, ExpectedDelivery = number, Shipped = false, OrderDate = DateTime.Now });
            modelbuilder.Entity<Order>().HasData(new Order { Id = 2, ShippingDate = DateTime.Now, ExpectedDelivery = number, Shipped = false, OrderDate = DateTime.Now });
            modelbuilder.Entity<Order>().HasData(new Order { Id = 3, ShippingDate = DateTime.Now, ExpectedDelivery = number, Shipped = false, OrderDate = DateTime.Now });

            // Cart
            modelbuilder.Entity<Cart>().HasData(new Cart { Id = 1 });
            modelbuilder.Entity<Cart>().HasData(new Cart { Id = 2 });
            modelbuilder.Entity<Cart>().HasData(new Cart { Id = 3 });

            // Item
            modelbuilder.Entity<Item>().HasData(new Item { Id = 1, CartId = 1, ProductIdRef = 1, Quantity = 1, });
            //modelbuilder.Entity<Item>().HasData(new Item { Id = 2, CartId = 2, ProductIdRef = 2, Quantity = 2, });

            // Join Fluent API
            modelbuilder.Entity<Product>()
                .HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity(j => j.HasData(
                    new { CategoriesId = 2, ProductsId = 1 },
                    new { CategoriesId = 2, ProductsId = 2 },
                    new { CategoriesId = 2, ProductsId = 3},
                    new { CategoriesId = 1, ProductsId = 4 }
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
                    Id = adminId,
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
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
                    UserName = "karen@manager.com",
                    NormalizedUserName = "KAREN@MANAGER.COM",
                    FirstName = "Karen",
                    LastName = "Managerson",
                    CreditCardNumber = "123",
                    CartId = 2,
                    OrderId = 2,
                    PasswordHash = passwordHasher.HashPassword(null, "password")
                },
                new ApplicationUser
                {
                    Id = userId,
                    Email = "random@user.com",
                    NormalizedEmail = "RANDOM@USER.COM",
                    UserName = "random@user.com",
                    NormalizedUserName = "RANDOM@USER.COM",
                    FirstName = "Joe",
                    LastName = "Sixpack",
                    CreditCardNumber = "123",
                    CartId = 3,
                    OrderId = 3,
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
                },
				new IdentityUserRole<string>
				{
					RoleId = userId,
					UserId = userId
				}
			);
        }

        //public DbSet<MVC_Webshop.ViewModels.CategoryCreateViewModel> CategoryCreateViewModel { get; set; }

        //public DbSet<MVC_Webshop.ViewModels.CategoryCreateViewModel> CategoryCreateViewModel { get; set; }

        //public DbSet<MVC_Webshop.ViewModels.ProductCreateViewModel> ProductCreateViewModel { get; set; }
    }
}