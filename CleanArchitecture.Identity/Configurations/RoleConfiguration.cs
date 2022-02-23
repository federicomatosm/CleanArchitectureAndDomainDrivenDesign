using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {

            
            
            builder.HasData(
                new IdentityRole
                {
                    Id= "0bc17709-3b9b-475d-8283-f8e09d2a6665",
                    Name="Administrator",
                    NormalizedName="ADMINISTRATOR"
                },
                  new IdentityRole
                  {
                      Id = "9060459c-57e2-46cd-9fe9-71a795538f19",
                      Name = "Operator",
                      NormalizedName = "OPERATOR"
                  }
                );
        }
    }
}

