using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DrinkStores.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Red tea",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/hong_tra_c922d28b002c4ef2a2033eea778902ff.jpg",
                        Price = 2,
                        Discount = 1,
                        Category = "Milk Tea",
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Tea Matcha",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/tra-nhbt-dbu-dj_3738874722904bb78ab0a36bce5ae13b.png",
                        Price = 5,
                        Category = "Milk Tea",
                        Discount = 2,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Tea Olong Baby Coffe",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/1587915993143_o_long_tran_chau_baby_kem_cafe_4f7d44a3d40f4460a49e37b9456eb775.jpg",
                        Price = 4,
                        Category = "Milk Tea",
                        Discount = 1,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Tiger Sugar",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/1587915993143_o_long_tran_chau_baby_kem_cafe_4f7d44a3d40f4460a49e37b9456eb775.jpg",
                        Price = 7,
                        Category = "Milk Tea",
                        Discount = 2,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Milk Tea",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/tra_sua_a38e4b5e8d884da2aa1575f43ee07efe.jpg",
                        Price = 6,
                        Category = "Milk Tea",
                        Discount = 2,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "XUASHAN1",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/che-1_561bdbdb1c1742139d09cd48faa2884c.png",
                        Price = 2,
                        Category="Che",
                        Discount = 0,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Hồng Long Bạch Ngọc",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/bach_ngoc_b2c1593a0c01450ba9120cb496eac6d8.jpg",
                        Price = 3,
                        Category = "Fruit",
                        Discount = 1,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Hồng Long Pha Lê Tuyết",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/bach_ngoc_b2c1593a0c01450ba9120cb496eac6d8.jpg",
                        Price = 4,
                        Category = "Fruit",
                        Discount = 0,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Hồng Trà Bưởi Mật Ong",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/che-13_7598d0e323484934b1be85bbc92baf58.png",
                        Price = 3,
                        Category = "Fruit",
                        Discount = 0,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Trà Dâu Tằm",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/dau_tam_pha_le_tuyet_41b439742cce4f1e943913135db24f82.jpg",
                        Price = 3,
                        Category = "Fruit",
                        Discount = 0,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Trà Xanh",
                        Description = "this is a category use for drink",
                        Img = "https://product.hstatic.net/1000360860/product/tx_84aab10e637c4f15a1bad0e7784f1554.jpg",
                        Price = 3,
                        Category = "Fruit",
                        Discount = 0,
                        Status = "stocking"
                    }
                    ); 
                context.SaveChanges();
            }
        }
    }
}
