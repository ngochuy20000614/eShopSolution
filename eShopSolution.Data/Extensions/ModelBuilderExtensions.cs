using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //seed data for AppConfig
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is  home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is  keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is  description of eShopSolution" });

            //seed data for Language
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = true });

            //seed data for Category
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    isShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Enums.Status.Active,
                },
                new Category()
                {
                    Id = 2,
                    isShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Enums.Status.Active,
                });

            //seed data for CategoryTranslation
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Men Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "men-shirt",
                    SeoDescription = "The shirt products for men",
                    SeoTitle = "The shirt products for men"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm áo thời trang nữ",
                    SeoTitle = "Sản phẩm áo thời trang nữ"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "women-shirt",
                    SeoDescription = "The shirt products for women",
                    SeoTitle = "The shirt products for women"
                }) ;

            //seed data for Product
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,                   
                });

            //seed data for ProductTranslation
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi nam trang Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                    SeoDescription = "Áo sơ mi nam trang Việt Tiến",
                    SeoTitle = "Áo sơ mi nam trang Việt Tiến",
                    Details = "Áo sơ mi nam trang Việt Tiến",
                    Description = "Áo sơ mi nam trang Việt Tiến"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet Tien Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "viet-tien-men-t-shirt",
                    SeoDescription = "Viet Tien Men T-Shirt",
                    SeoTitle = "Viet Tien Men T-Shirt",
                    Details = "Viet Tien Men T-Shirt",
                    Description = "Viet Tien Men T-Shirt"
                });

            //seed data for ProductInCategory
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }
    }
}
