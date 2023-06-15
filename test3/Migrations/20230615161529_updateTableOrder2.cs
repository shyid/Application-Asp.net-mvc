using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class updateTableOrder2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b05053ca-3b03-44eb-a6f0-e893e1c83131", "52f4f92a-0c3c-4fc9-9ca7-390bf5f208a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc0e8fda-2c4e-47e0-9aa2-e181b932f35e", "5ebd560c-de63-499c-9959-ce5fd93a11dc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b05053ca-3b03-44eb-a6f0-e893e1c83131");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc0e8fda-2c4e-47e0-9aa2-e181b932f35e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52f4f92a-0c3c-4fc9-9ca7-390bf5f208a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ebd560c-de63-499c-9959-ce5fd93a11dc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23ffa4d3-014d-4c12-b104-32449991eb73", null, "Member", "MEMBER" },
                    { "38a543fe-2368-4f52-9ade-927a114ea037", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "652cca89-dd20-43c8-8712-cc8883e4e466", 0, "5f40820a-6ec1-4d5c-9c2a-a0e6e7fab412", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAECBtdkl7KuETEkRWgOotEVQoLOg36+CIkrUFK8lrh5ZzFLSciCxo23CGWjkZtcmaZg==", null, false, "6bcecaf8-818d-40e1-8f10-4b712cbeda80", false, "aa@aa.aa" },
                    { "f188ac90-674a-42c5-ba7a-aa279216295b", 0, "86df182d-dcb5-43e1-a830-834abd8ded5e", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEPPA4Q56xBy627JLWF9DgjAy2VIG7yv0EXXRA6VC6mRRPC7Hiw4QzjBPx/EcxKRiMg==", null, false, "6b1849e2-e45f-424d-a83d-003711ba9411", false, "mm@mm.mm" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "38a543fe-2368-4f52-9ade-927a114ea037", "652cca89-dd20-43c8-8712-cc8883e4e466" },
                    { "23ffa4d3-014d-4c12-b104-32449991eb73", "f188ac90-674a-42c5-ba7a-aa279216295b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38a543fe-2368-4f52-9ade-927a114ea037", "652cca89-dd20-43c8-8712-cc8883e4e466" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "23ffa4d3-014d-4c12-b104-32449991eb73", "f188ac90-674a-42c5-ba7a-aa279216295b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23ffa4d3-014d-4c12-b104-32449991eb73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38a543fe-2368-4f52-9ade-927a114ea037");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "652cca89-dd20-43c8-8712-cc8883e4e466");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f188ac90-674a-42c5-ba7a-aa279216295b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b05053ca-3b03-44eb-a6f0-e893e1c83131", null, "Member", "MEMBER" },
                    { "cc0e8fda-2c4e-47e0-9aa2-e181b932f35e", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "52f4f92a-0c3c-4fc9-9ca7-390bf5f208a8", 0, "33174793-8d4a-4918-b794-34c50a483372", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEFQGxnBxFWkSlLQzH6XoH4ecwRLVG36KJMIXwWLseyewDGhPOo4BBxJeYHcuPPqE7A==", null, false, "34ba61e5-60a5-4ff7-a160-4c98e0063f1e", false, "mm@mm.mm" },
                    { "5ebd560c-de63-499c-9959-ce5fd93a11dc", 0, "e31bfd91-1507-4f4c-b031-9f8841c3be0c", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEAz54jFOjjqAbtzMoZ7act1DV0GbZvj/f+2HkR74Nm4qvP6K6khPU/OBsb5J0aLO+Q==", null, false, "f22440a5-5b3b-4459-a577-1e74c63cfe85", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b05053ca-3b03-44eb-a6f0-e893e1c83131", "52f4f92a-0c3c-4fc9-9ca7-390bf5f208a8" },
                    { "cc0e8fda-2c4e-47e0-9aa2-e181b932f35e", "5ebd560c-de63-499c-9959-ce5fd93a11dc" }
                });
        }
    }
}
