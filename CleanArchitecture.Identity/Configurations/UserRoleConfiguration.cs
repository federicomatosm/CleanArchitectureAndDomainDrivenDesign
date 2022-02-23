    using System;
using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    namespace CleanArchitecture.Identity.Configurations
    {
	    public class UserRoleConfiguration :IEntityTypeConfiguration<ApplicationUser>
	    {
		

            public void Configure(EntityTypeBuilder<ApplicationUser> builder)
            {
            //TODO Check why this error: The seed entity for entity type 'ApplicationUser' cannot be added because no value was provided for the required property 'Id'.
            /*
             builder.HasData(
                 new IdentityUserRole<string>
                 {
                     RoleId= "0bc17709-3b9b-475d-8283-f8e09d2a6665",
                     UserId= "3994b47e-bb7b-4e3e-8a30-786e59391241"

                 },
                  new IdentityUserRole<string>
                  {
                      RoleId = "9060459c-57e2-46cd-9fe9-71a795538f19",
                      UserId = "7fb18dfc-545d-44e2-b00c-4c8a5f2a729c"

                  }

                 );*/
        }
    }
    }

