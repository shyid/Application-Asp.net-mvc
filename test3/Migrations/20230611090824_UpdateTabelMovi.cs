using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTabelMovi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6f155cfc-dc03-420a-9db3-1f75db1e4a06", "089df2c2-9ab1-43e9-b93c-cd979cf2caac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2d02f19-2808-45f3-a977-2bc34046b41d", "78d8bc58-726e-4f6b-bd55-43d539529361" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f155cfc-dc03-420a-9db3-1f75db1e4a06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2d02f19-2808-45f3-a977-2bc34046b41d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "089df2c2-9ab1-43e9-b93c-cd979cf2caac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78d8bc58-726e-4f6b-bd55-43d539529361");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48f7a0ed-6cb3-4bd0-8a03-82612bad39d4", null, "Admin", "ADMIN" },
                    { "72ecf6c3-1639-4adc-951a-0a00ed8d1143", null, "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3ae4e27a-a0a1-4a5d-9f79-eca8d60fc7d1", 0, "a440dd00-413a-43b4-b698-638f02d4448e", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEFKaodKmSIt9NEizx1o7rA8AnwZb7eYAXYQvBearZTCMjZsPYfjHj1CZgtGdKwV5XQ==", null, false, "c91517c0-78be-419b-a54c-1deb43cd16cc", false, "mm@mm.mm" },
                    { "b68fe4a0-ab51-4094-8536-89e579915506", 0, "b0247730-a638-411f-9dd1-48f5678345f3", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEFQhdtVv8weIIOZr3duVLcbW4b/o27950B8ZF8blCo8OCpdW7v3qpxuPhRUPtyUPnw==", null, false, "066a9472-56b0-4931-b6c4-16c1c2e832dd", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "72ecf6c3-1639-4adc-951a-0a00ed8d1143", "3ae4e27a-a0a1-4a5d-9f79-eca8d60fc7d1" },
                    { "48f7a0ed-6cb3-4bd0-8a03-82612bad39d4", "b68fe4a0-ab51-4094-8536-89e579915506" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72ecf6c3-1639-4adc-951a-0a00ed8d1143", "3ae4e27a-a0a1-4a5d-9f79-eca8d60fc7d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "48f7a0ed-6cb3-4bd0-8a03-82612bad39d4", "b68fe4a0-ab51-4094-8536-89e579915506" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "48f7a0ed-6cb3-4bd0-8a03-82612bad39d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72ecf6c3-1639-4adc-951a-0a00ed8d1143");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ae4e27a-a0a1-4a5d-9f79-eca8d60fc7d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b68fe4a0-ab51-4094-8536-89e579915506");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6f155cfc-dc03-420a-9db3-1f75db1e4a06", null, "Member", "MEMBER" },
                    { "e2d02f19-2808-45f3-a977-2bc34046b41d", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "089df2c2-9ab1-43e9-b93c-cd979cf2caac", 0, "c3959f19-9547-43a8-ac43-2092cd54e68d", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAENgadlSMlH7N2oEabC2FQimt9e2NXpQbFzvA9aRcwewsJukU6gLbe2hXMENiJ6PvfQ==", null, false, "a6b82a70-9a3d-48fb-988a-edc7063006b4", false, "mm@mm.mm" },
                    { "78d8bc58-726e-4f6b-bd55-43d539529361", 0, "0fcb0aa9-8d46-4b85-847d-3ab5b018a7eb", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAENOKmfWOhfVuTx0JXyvD23qOTX10DCRCQRiw6/UOsnjGyeqMXJ6wr0n5x+Kx2VhpDQ==", null, false, "81d6e4a3-3b28-4be0-b355-44beb124d906", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6f155cfc-dc03-420a-9db3-1f75db1e4a06", "089df2c2-9ab1-43e9-b93c-cd979cf2caac" },
                    { "e2d02f19-2808-45f3-a977-2bc34046b41d", "78d8bc58-726e-4f6b-bd55-43d539529361" }
                });
        }
    }
}
