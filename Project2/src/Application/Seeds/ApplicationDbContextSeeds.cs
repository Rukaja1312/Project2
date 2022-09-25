using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Project2.Application.Seeds;
public class ApplicationDbContextSeeds
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
        {
            if (!context.SearchByBrands.Any())
            {
                context.SearchByBrands.AddRange(
                     new SearchByBrand
                     {
                         Name = "VW"
                     },
                     new SearchByBrand
                     {
                         Name = "Mercedes-Benz"
                     },
                     new SearchByBrand
                     {
                         Name = "BMW"
                     },
                     new SearchByBrand
                     {
                         Name = "Audi"
                     },
                     new SearchByBrand
                     {
                         Name = "Opel"
                     },
                     new SearchByBrand
                     {
                         Name = "Peugeot"
                     },
                     new SearchByBrand
                     {
                         Name = "Renault"
                     },
                     new SearchByBrand
                     {
                         Name = "Toyota"
                     },
                     new SearchByBrand
                     {
                         Name = "Ford"
                     },
                     new SearchByBrand
                     {
                         Name = "Citroen"
                     },
                     new SearchByBrand
                     {
                         Name = "Nissan"
                     },
                     new SearchByBrand
                     {
                         Name = "Fiat"
                     },
                     new SearchByBrand
                     {
                         Name = "Mazda"
                     },
                     new SearchByBrand
                     {
                         Name = "Honda"
                     },
                     new SearchByBrand
                     {
                         Name = "Seat"
                     },
                     new SearchByBrand
                     {
                         Name = "Skoda"
                     },
                     new SearchByBrand
                     {
                         Name = "Hyundai"
                     },
                     new SearchByBrand
                     {
                         Name = "Mitsubishi"
                     },
                     new SearchByBrand
                     {
                         Name = "Kia"
                     },
                     new SearchByBrand
                     {
                         Name = "Volvo"
                     },
                     new SearchByBrand
                     {
                         Name = "Suzuki"
                     },
                     new SearchByBrand
                     {
                         Name = "Alfa Romeo"
                     },
                     new SearchByBrand
                     {
                         Name = "Chevrolet"
                     },
                     new SearchByBrand
                     {
                         Name = "Dacia"
                     },
                     new SearchByBrand
                     {
                         Name = "Land Rover"
                     },
                     new SearchByBrand
                     {
                         Name = "Jeep"
                     },
                     new SearchByBrand
                     {
                         Name = "Mini"
                     },
                     new SearchByBrand
                     {
                         Name = "Chrysler"
                     },
                     new SearchByBrand
                     {
                         Name = "Lancia"
                     },
                     new SearchByBrand
                     {
                         Name = "Daihatsu"
                     },
                     new SearchByBrand
                     {
                         Name = "Ssangyong"
                     },
                      new SearchByBrand
                      {
                          Name = "Porsche"
                      },
                     new SearchByBrand
                     {
                         Name = "Jaguar"
                     },
                     new SearchByBrand
                     {
                         Name = "Smart"
                     },
                     new SearchByBrand
                     {
                         Name = "Rover"
                     },
                     new SearchByBrand
                     {
                         Name = "Daewoo"
                     },
                     new SearchByBrand
                     {
                         Name = "Saab"
                     },
                     new SearchByBrand
                     {
                         Name = "Lada"
                     },
                     new SearchByBrand
                     {
                         Name = "Lexus"
                     },
                     new SearchByBrand
                     {
                         Name = "Dodge"
                     },
                     new SearchByBrand
                     {
                         Name = "Infiniti"
                     },
                     new SearchByBrand
                     {
                         Name = "Isuzu"
                     },
                     new SearchByBrand
                     {
                         Name = "Great wall"
                     },
                     new SearchByBrand
                     {
                         Name = "Tesla"
                     },
                     new SearchByBrand
                     {
                         Name = "Range Rover"
                     },
                     new SearchByBrand
                     {
                         Name = "Moskvich"
                     },
                     new SearchByBrand
                     {
                         Name = "Cadillac"
                     },
                     new SearchByBrand
                     {
                         Name = "Tata"
                     },
                     new SearchByBrand
                     {
                         Name = "UAZ"
                     },
                     new SearchByBrand
                     {
                         Name = "Trabant"
                     },
                     new SearchByBrand
                     {
                         Name = "Volga"
                     },
                     new SearchByBrand
                     {
                         Name = "Lincoln"
                     },
                     new SearchByBrand
                     {
                         Name = "Pontiac"
                     },
                     new SearchByBrand
                     {
                         Name = "DR"
                     },
                     new SearchByBrand
                     {
                         Name = "Maserati"
                     },
                     new SearchByBrand
                     {
                         Name = "MG"
                     },
                     new SearchByBrand
                     {
                         Name = "Hummer"
                     },
                     new SearchByBrand
                     {
                         Name = "Bentley"
                     },
                     new SearchByBrand
                     {
                         Name = "GAZ"
                     },
                     new SearchByBrand
                     {
                         Name = "ВАЗ"
                     },
                     new SearchByBrand
                     {
                         Name = "Wartburg"
                     },
                     new SearchByBrand
                     {
                         Name = "Zaz"
                     },
                      new SearchByBrand
                      {
                          Name = "Acura"
                      },
                     new SearchByBrand
                     {
                         Name = "DS"
                     },
                     new SearchByBrand
                     {
                         Name = "Rolls Royce"
                     },
                     new SearchByBrand
                     {
                         Name = "Iveco"
                     },
                     new SearchByBrand
                     {
                         Name = "GMC"
                     },
                     new SearchByBrand
                     {
                         Name = "Buick"
                     },
                     new SearchByBrand
                     {
                         Name = "Mahindra"
                     },
                     new SearchByBrand
                     {
                         Name = "Lamborghini"
                     },
                     new SearchByBrand
                     {
                         Name = "Ferrari"
                     },
                     new SearchByBrand
                     {
                         Name = "Asia Motors"
                     },
                     new SearchByBrand
                     {
                         Name = "Haval"
                     },
                     new SearchByBrand
                     {
                         Name = "Barkas"
                     },
                     new SearchByBrand
                     {
                         Name = "Aro"
                     },
                     new SearchByBrand
                     {
                         Name = "Shuanghuan"
                     },
                     new SearchByBrand
                     {
                         Name = "Aixam"
                     },
                     new SearchByBrand
                     {
                         Name = "Datsun"
                     },
                     new SearchByBrand
                     {
                         Name = "Piaggio"
                     },
                     new SearchByBrand
                     {
                         Name = "Yogomo"
                     },
                     new SearchByBrand
                     {
                         Name = "Oldsmobile"
                     },
                     new SearchByBrand
                     {
                         Name = "Santana"
                     },
                     new SearchByBrand
                     {
                         Name = "Plymouth"
                     },
                     new SearchByBrand
                     {
                         Name = "Simca"
                     },
                     new SearchByBrand
                     {
                         Name = "Triumph"
                     },
                     new SearchByBrand
                     {
                         Name = "Scion"
                     },
                     new SearchByBrand
                     {
                         Name = "Austin"
                     },
                     new SearchByBrand
                     {
                         Name = "Gac Gonow"
                     },
                     new SearchByBrand
                     {
                         Name = "Talbot"
                     },
                     new SearchByBrand
                     {
                         Name = "Landwind"
                     },
                     new SearchByBrand
                     {
                         Name = "Alpina"
                     },
                     new SearchByBrand
                     {
                         Name = "Aston Martin"
                     }
                    );
            }
            if (!context.UserRoles.Any())
            {
                string ADMIN_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
                string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";

                context.Roles.Add(new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = ROLE_ID,
                    ConcurrencyStamp = ROLE_ID
                });

                var appUser = new User
                {
                    Id = ADMIN_ID,
                    Email = "Admin@admin.com",
                    EmailConfirmed = true,
                    UserName = "Admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.COM"
                };

                PasswordHasher<User> ph = new PasswordHasher<User>();
                appUser.PasswordHash = ph.HashPassword(appUser, "password");
                context.Users.Add(appUser);

                context.UserRoles.Add(new IdentityUserRole<string>
                {
                    RoleId = ROLE_ID,
                    UserId = ADMIN_ID
                });
            }
            context.SaveChanges();
        }
    }
}