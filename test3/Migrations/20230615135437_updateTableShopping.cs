using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class updateTableShopping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be3601a4-c8d7-4e78-9be6-acd908ef817c", "78a90d6a-beaf-4f9f-b8b1-ed8cb2d190ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1969fcda-13c4-49f8-a088-0834a8382115", "a97ec12f-4abd-4d3d-8482-11b87ef0353a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1969fcda-13c4-49f8-a088-0834a8382115");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be3601a4-c8d7-4e78-9be6-acd908ef817c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78a90d6a-beaf-4f9f-b8b1-ed8cb2d190ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a97ec12f-4abd-4d3d-8482-11b87ef0353a");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1969fcda-13c4-49f8-a088-0834a8382115", null, "Admin", "ADMIN" },
                    { "be3601a4-c8d7-4e78-9be6-acd908ef817c", null, "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78a90d6a-beaf-4f9f-b8b1-ed8cb2d190ef", 0, "0e09f9c4-0b7a-4c11-a188-c497f17a69da", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEKoUS+t920nVhTbu2qQtrKK7VKaz9uel6er0Q/0/nzo8gxPK+nuoxndSBrVcrDwONw==", null, false, "f763cf73-6eb3-4c05-a001-678f9d935c11", false, "mm@mm.mm" },
                    { "a97ec12f-4abd-4d3d-8482-11b87ef0353a", 0, "8f935f4d-873f-407e-ac4d-c5db8b985f1c", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEA4HXgIsnFptESPdGYsZvL0LhCKqLr+DUG6mOk2GCfgZjyR/xInbSib+8iz52QprEg==", null, false, "f2e8d9b1-ac8b-40d8-9867-b5c5381fb0b1", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "be3601a4-c8d7-4e78-9be6-acd908ef817c", "78a90d6a-beaf-4f9f-b8b1-ed8cb2d190ef" },
                    { "1969fcda-13c4-49f8-a088-0834a8382115", "a97ec12f-4abd-4d3d-8482-11b87ef0353a" }
                });
        }
    }
}
