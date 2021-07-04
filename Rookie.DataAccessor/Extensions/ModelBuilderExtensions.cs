using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rookie.DataAccessor.Entities;

namespace Rookie.DataAccessor.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = new Guid("D6C40780-01EF-466E-8AE0-0B3C51D62285"), Name="Alaska",Description="Giong cho tu Chau Au",Price=12000000,Images="/alaska.png",CreatedDate=DateTime.Now},
                new Product() { Id = new Guid("E044DE2D-2183-445C-A821-0B06FEC05CD4"), Name = "Cho Phu Quoc", Description = "Giong cho tu Viet Nam", Price = 8000000, Images = "/phuquoc.png", CreatedDate = DateTime.Now },
                new Product() { Id = new Guid("A742EEC4-A3A1-4623-B146-97F21D227080"), Name = "shiba", Description = "Giong cho tu Nhat Ban", Price = 35000000, Images = "/shiba.png", CreatedDate = DateTime.Now },
                new Product() { Id = new Guid("290D1A74-0839-4919-A2B2-6A5BCF097757"), Name = "Thuc an loai A", Description = "Thuc an loai tot nhat", Price = 3000000, Images = "/loaiA.png", CreatedDate = DateTime.Now },
                new Product() { Id = new Guid("E3BC0D45-6F0E-4E04-B06F-9DD6BA0190F9"), Name = "Thuc an loai B", Description = "Thuc an loai vua", Price = 2000000, Images = "/loaiB.png", CreatedDate = DateTime.Now },
                new Product() { Id = new Guid("5C6ECE7A-4BCC-4690-BB51-C42034178DB0"), Name = "Thuc an loai C", Description = "Thuc an loai binh thuong", Price = 1000000, Images = "/loaiC.png", CreatedDate = DateTime.Now }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = new Guid("E1D33FDA-2FA3-4927-A07A-2BFC243DF88F"), Name = "Thu cung", Description = "Mua ban cac loai thu cung", CreatedDate = DateTime.Now },
                new Category() { Id = new Guid("DE876948-CBE2-4740-B944-030EF8E40C28"), Name = "Thuc an cho Pet", Description = "Cac loai thuc an danh cho thu cung", CreatedDate = DateTime.Now }
                );
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory() { ProductId = new Guid("D6C40780-01EF-466E-8AE0-0B3C51D62285"), CategoryId = new Guid("E1D33FDA-2FA3-4927-A07A-2BFC243DF88F") },
                new ProductCategory() { ProductId = new Guid("E044DE2D-2183-445C-A821-0B06FEC05CD4"), CategoryId = new Guid("E1D33FDA-2FA3-4927-A07A-2BFC243DF88F") },
                new ProductCategory() { ProductId = new Guid("A742EEC4-A3A1-4623-B146-97F21D227080"), CategoryId = new Guid("E1D33FDA-2FA3-4927-A07A-2BFC243DF88F") },
                new ProductCategory() { ProductId = new Guid("290D1A74-0839-4919-A2B2-6A5BCF097757"), CategoryId = new Guid("DE876948-CBE2-4740-B944-030EF8E40C28") },
                new ProductCategory() { ProductId = new Guid("E3BC0D45-6F0E-4E04-B06F-9DD6BA0190F9"), CategoryId = new Guid("DE876948-CBE2-4740-B944-030EF8E40C28") },
                new ProductCategory() { ProductId = new Guid("5C6ECE7A-4BCC-4690-BB51-C42034178DB0"), CategoryId = new Guid("DE876948-CBE2-4740-B944-030EF8E40C28") }
                );

        }
    }
}
