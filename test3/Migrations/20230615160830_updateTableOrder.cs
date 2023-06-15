using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class updateTableOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_Orders_UserId",
                table: "orderItems");

            migrationBuilder.DropIndex(
                name: "IX_orderItems_UserId",
                table: "orderItems");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b50b4198-4b0f-49a8-8106-50bff6a82995", "17577619-f1d9-4e72-ad9d-bf3b7f32552a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a5571c9-535b-4146-a979-201c8db6847e", "9ca3e3d1-dbbb-4711-82b0-0be88c40f383" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a5571c9-535b-4146-a979-201c8db6847e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b50b4198-4b0f-49a8-8106-50bff6a82995");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17577619-f1d9-4e72-ad9d-bf3b7f32552a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ca3e3d1-dbbb-4711-82b0-0be88c40f383");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "orderItems");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "User",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "orderItems",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a5571c9-535b-4146-a979-201c8db6847e", null, "Member", "MEMBER" },
                    { "b50b4198-4b0f-49a8-8106-50bff6a82995", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17577619-f1d9-4e72-ad9d-bf3b7f32552a", 0, "540c7cc1-4739-4fb5-aa35-cb15720c1200", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAELXwpLSjlZC5CjZs5NhOp0EktDtyaoJ12YpOTfY9Tf2CQchnrG4+BZLQLVdnJULJPA==", null, false, "ad17ef98-53e8-4002-8ebc-4f2472878348", false, "aa@aa.aa" },
                    { "9ca3e3d1-dbbb-4711-82b0-0be88c40f383", 0, "208f9e10-8755-4c71-9757-84d0e1a722c5", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAELl85iamin5P/SAoQrizIbgwqh4sqH56NVG7If+Fq3SLPqOllhgT//g7C1HiWxJTbw==", null, false, "adc37c4a-e39a-46e4-9b3c-0069d98e0600", false, "mm@mm.mm" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b50b4198-4b0f-49a8-8106-50bff6a82995", "17577619-f1d9-4e72-ad9d-bf3b7f32552a" },
                    { "5a5571c9-535b-4146-a979-201c8db6847e", "9ca3e3d1-dbbb-4711-82b0-0be88c40f383" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_UserId",
                table: "orderItems",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_Orders_UserId",
                table: "orderItems",
                column: "UserId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
