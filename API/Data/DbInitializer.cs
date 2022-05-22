using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {  
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});

            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
            
                new Product
                {
                    Name = "Belle Kids 2pcs Floral",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/2pcs.image.3.floral-BelleKids.png",
                    Brand = "Belle Kids",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Belle Kids 3pcs Summer Charm",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/2pcs.image.4.green-BelleKids.png",
                    Brand = "Belle Kids",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lunar Butterfly 2pcs Blue Outfit",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/2pcs.images.5.blue-Lunar.png",
                    Brand = "Lunar",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Bijou Animal Print Dress",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/dress.image.6.animalprint-Bijou.png",
                    Brand = "Bijou",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Bijou Floral Summer Dress",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/dress.image.7.flora-Bijou.png",
                    Brand = "Bijou",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Bijou Chic Summer Dress",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 32000,
                    PictureUrl = "/images/products/dress.image.8.floralwithpurse-Bijou.png",
                    Brand = "Bijou",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Bijou Summer Berry Dress",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 14000,
                    PictureUrl = "/images/products/dress.image.9.strawberry-Bijou.png",
                    Brand = "Bijou",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Bijou Daisy Denin Dress",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 10500,
                    PictureUrl = "/images/products/dress.image01.jeans-Bijou.png",
                    Brand = "Bijou",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Kids Planet Little Gardner Jumpsuit",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 14800,
                    PictureUrl = "/images/products/jumpsuit.image.10.flora-KidsPlanet.png",
                    Brand = "Kids Planet",
                    Type = "Jumpsuit",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Kids Planet Frenchy Jumpsuit",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 22000,
                    PictureUrl = "/images/products/jumpsuit.image.11.blackandwhite-KidsPlanet.png",
                    Brand = "Kids Planet",
                    Type = "Jumpsuit",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Kids Planet Baby-Daisy Jumpsuit",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 15000,
                    PictureUrl = "/images/products/jumpsuit.image1.orange-KidsPlanet.png",
                    Brand = "Kids Planet",
                    Type = "Jumpsuit",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dreamer Unicorn Party Pajama",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 9800,
                    PictureUrl = "/images/products/pajama.image.18.unicorn-Dreamer.png",
                    Brand = "Dreamer",
                    Type = "Pajamas",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Dreamer Pretty Kat Pajama",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 9800,
                    PictureUrl = "/images/products/pajamas.image.17-Dreamer.png",
                    Brand = "Dreamer",
                    Type = "Pajamas",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Lunar Lace Party Dress",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/partydress.image.15.yellow-Lunar.png",
                    Brand = "Lunar",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Belle Kids Tre Chic Dress",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 35000,
                    PictureUrl = "/images/products/partydress.image.16.pink-BelleKids.png",
                    Brand = "Belle Kids",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Belle Kids Galla Dress",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 36000,
                    PictureUrl = "/images/products/partydress.image.17.peach-BelleKids.png",
                    Brand = "Bell Kids",
                    Type = "Dress",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pitchuca Donut Swimmingsuit",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/swimmingsuit.image.12.donut-Pitchuca.png",
                    Brand = "Pitchuca",
                    Type = "Swimmingsuit",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pitchuca Popsicle Swimmingsuit",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/swimmingsuit.image.14.popsicle-Pitchuca.png",
                    Brand = "Pitchuca",
                    Type = "Swimmingsuit",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}