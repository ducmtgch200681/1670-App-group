using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using The_cool_Library.Models;

namespace The_cool_Library.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<StoreOwner> StoreOwners { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        /*
        
        public DbSet<Order> Orders { get; set; }
       
        */

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Bonus form
            //Note: add dữ liệu cho bảng chứa PK trước (University)
            //rồi add dữ liệu cho bảng chứa FK sau (Student)

            //add dữ liệu khởi tạo cho bảng University
            //PopulateUniversity(builder);

            //add dữ liệu khởi tạo (initial data) cho bảng Student
            //SeedStudent(builder);
            //----------------------------------------------------

            //add dữ liệu cho bảng User
            SeedUser(builder);

            //add dữ liệu cho bảng Role
            SeedRole(builder);

            //add dữ liệu cho bảng UserRole
            SeedUserRole(builder);
        }

        //Tạo tài khoản add vào DB
        private void SeedUser(ModelBuilder builder)
        {
            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "admin@fpt.com",
                Email = "admin@fpt.com",
                NormalizedUserName = "admin@fpt.com",
                EmailConfirmed = true
            };

            var customer = new IdentityUser
            {
                Id = "2",
                UserName = "customer@fpt.com",
                Email = "customer@fpt.com",
                NormalizedUserName = "customer@fpt.com",
                EmailConfirmed = true
            };

            var storeOwner = new IdentityUser
            {
                Id = "3",
                UserName = "storeOwner@fpt.com",
                Email = "storeOwner@fpt.com",
                NormalizedUserName = "storeOwner@fpt.com",
                EmailConfirmed = true
            };

            //Khai báo thư viện để mã hóa mk
            var hashed = new PasswordHasher<IdentityUser>();

            //Thiết lập để mã hóa từng tài khoản
            admin.PasswordHash = hashed.HashPassword(admin, "12345");
            customer.PasswordHash = hashed.HashPassword(customer, "54321");
            storeOwner.PasswordHash = hashed.HashPassword(storeOwner, "123456");

            //Add tài khoản vào DB
            builder.Entity<IdentityUser>().HasData(admin, customer, storeOwner);
        }


        //Add Role
        private void SeedRole(ModelBuilder builder)
        {
            //1. tạo các role cho hệ thống
            var admin = new IdentityRole
            {
                Id = "A",
                Name = "Administrator",
                NormalizedName = "Administrator"
            };

            var customer = new IdentityRole
            {
                Id = "B",
                Name = "Customer",
                NormalizedName = "Customer"
            };

            var storeOwner = new IdentityRole
            {
                Id = "C",
                Name = "StoreOwner",
                NormalizedName = "StoreOwner"
            };

            //2. add role vào trong DB
            builder.Entity<IdentityRole>().HasData(admin, customer, storeOwner);
        }


        //Conect role with user
        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "A"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "B"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "C"
                }
             );
        }
    }
}
