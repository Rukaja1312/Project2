using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Project2.Application;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }

    public DbSet<Dealer> Dealers { get; set; }

    public DbSet<SearchByBrand> SearchByBrands { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    //string ADMIN_ID = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
    //    //string ROLE_ID = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";

    //    //modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
    //    //{
    //    //    Name = "Admin",
    //    //    NormalizedName = "ADMIN",
    //    //    Id = ROLE_ID,
    //    //    ConcurrencyStamp = ROLE_ID
    //    //});

    //   // var appUser = new User
    //   // {
    //   //     Id = ADMIN_ID,
    //   //     Email = "Admin@admin.com",
    //   //     EmailConfirmed = true,
    //   //     UserName = "Admin@admin.com",
    //   //     NormalizedUserName = "ADMIN@ADMIN.COM"
    //   // };
    //   //
    //   // PasswordHasher<User> ph = new PasswordHasher<User>();
    //   // appUser.PasswordHash = ph.HashPassword(appUser, "password");

    //    //modelBuilder.Entity<User>().HasData(appUser);

    //    //modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
    //    //{
    //    //    RoleId = ROLE_ID,
    //    //    UserId = ADMIN_ID
    //    //});
    //}
}
