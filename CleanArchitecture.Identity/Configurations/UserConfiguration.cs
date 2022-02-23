using System;
using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{


        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            
            var hasher = new PasswordHasher<ApplicationUser>();
            IEnumerable<ApplicationUser> users = new List<ApplicationUser>
            {
                 new ApplicationUser()
                {
                    Id = "3994b47e-bb7b-4e3e-8a30-786e59391241",
                    Email = "admin@federicomatos.com",
                    NormalizedEmail = "admin@federicomatos.com",
                    Name = "Federico",
                    LastName = "Matos",
                    UserName = "jerfymatos",
                    NormalizedUserName = "jerfymatos",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    EmailConfirmed = true
                },
                  new ApplicationUser()
                  {
                      Id = "7fb18dfc-545d-44e2-b00c-4c8a5f2a729c",
                      Email = "juanperez@federicomatos.com",
                      NormalizedEmail = "juanperez@federicomatos.com",
                      Name = "Juan",
                      LastName = "Perez",
                      UserName = "juanperez",
                      NormalizedUserName = "juanperez",
                      PasswordHash = hasher.HashPassword(null, "password"),
                      EmailConfirmed = true
                  }
            };
            
            builder.HasData(users

                );
        }
    }
}

