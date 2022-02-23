using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Identity.Migrations
{
    public partial class Seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3994b47e-bb7b-4e3e-8a30-786e59391241", 0, "ee7236dd-c8ff-4f3d-a1ee-ab5e5e8effd0", "admin@federicomatos.com", true, "Matos", false, null, "Federico", "admin@federicomatos.com", "jerfymatos", "AQAAAAEAACcQAAAAEMZAE+vuMDfbPZ+AXTrYqWpttR7MvVF0z5lOnmmXrzTf/wza5YN6UpTA89j2f80z9Q==", null, false, "4c5af898-7825-4b98-b367-dcb0d235d207", false, "jerfymatos" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7fb18dfc-545d-44e2-b00c-4c8a5f2a729c", 0, "e25570d9-a84d-42d2-a5bc-00e8b67a79fb", "juanperez@federicomatos.com", true, "Perez", false, null, "Juan", "juanperez@federicomatos.com", "juanperez", "AQAAAAEAACcQAAAAEAmWuy0LlHHHA4BDckLBhdyHtjhgwqYH57eKa6KGqJQoZty9q6iY0yVohiP8FLIK3w==", null, false, "898b88d3-6472-446b-8312-d1ffc1371db5", false, "juanperez" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3994b47e-bb7b-4e3e-8a30-786e59391241");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fb18dfc-545d-44e2-b00c-4c8a5f2a729c");
        }
    }
}
