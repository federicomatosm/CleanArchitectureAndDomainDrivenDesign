using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Identity.Migrations
{
    public partial class Seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3994b47e-bb7b-4e3e-8a30-786e59391241",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e8afe8c-0687-44f8-9ad2-79f3842b0f50", "AQAAAAEAACcQAAAAEJubbR7TXzuxS/d7QtQfAOKMFoTAHmn9EwsgWig8/EKc7KUpC6tRoL7WCNCw3gzcGQ==", "fdac9a4f-0dc2-49c2-84e7-509aa6835917" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fb18dfc-545d-44e2-b00c-4c8a5f2a729c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70546403-a3cc-4b4a-b6dc-13373ac744f8", "AQAAAAEAACcQAAAAEF/weXSXdyrYbtz3pWjfn59J7O7+xu44UMDrsYKotjwtRmiuKXA3b9JKdHeT3NBOdg==", "7fc04747-269b-4216-83b8-b06932fada01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3994b47e-bb7b-4e3e-8a30-786e59391241",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee7236dd-c8ff-4f3d-a1ee-ab5e5e8effd0", "AQAAAAEAACcQAAAAEMZAE+vuMDfbPZ+AXTrYqWpttR7MvVF0z5lOnmmXrzTf/wza5YN6UpTA89j2f80z9Q==", "4c5af898-7825-4b98-b367-dcb0d235d207" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fb18dfc-545d-44e2-b00c-4c8a5f2a729c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e25570d9-a84d-42d2-a5bc-00e8b67a79fb", "AQAAAAEAACcQAAAAEAmWuy0LlHHHA4BDckLBhdyHtjhgwqYH57eKa6KGqJQoZty9q6iY0yVohiP8FLIK3w==", "898b88d3-6472-446b-8312-d1ffc1371db5" });
        }
    }
}
