using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class newTabelNewMovieVM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b30cdb8e-99fa-46e9-87cf-bdff0d3a09c6", "a843608a-f6fb-4a93-bdb2-474549bbcf6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "47ba69c6-879c-4527-9748-7bc1b617da54", "f9f243e1-006d-4ec0-82be-48e756aafc46" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47ba69c6-879c-4527-9748-7bc1b617da54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b30cdb8e-99fa-46e9-87cf-bdff0d3a09c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a843608a-f6fb-4a93-bdb2-474549bbcf6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9f243e1-006d-4ec0-82be-48e756aafc46");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47ba69c6-879c-4527-9748-7bc1b617da54", null, "Member", "MEMBER" },
                    { "b30cdb8e-99fa-46e9-87cf-bdff0d3a09c6", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a843608a-f6fb-4a93-bdb2-474549bbcf6d", 0, "1e406695-a990-43c4-b36e-fd61c54f73cf", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEJ6Z9mKAetVhNOw5QgdamzjjoxuaSuekGGDECqYiRELXCR+oFM5VVGsGfvctYW3GDg==", null, false, "3ccafc96-2169-4560-844a-21f6ce223b24", false, "aa@aa.aa" },
                    { "f9f243e1-006d-4ec0-82be-48e756aafc46", 0, "07177807-8120-4e21-9b0d-764852c170b9", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEA/Tjw14SkcG89mQVZO6R6qvLDqatlgQLepNhbNoobbfyXCDeE/0auBF4DG8v013Uw==", null, false, "501ea318-ab82-4202-a448-d5dcc0c6196b", false, "mm@mm.mm" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b30cdb8e-99fa-46e9-87cf-bdff0d3a09c6", "a843608a-f6fb-4a93-bdb2-474549bbcf6d" },
                    { "47ba69c6-879c-4527-9748-7bc1b617da54", "f9f243e1-006d-4ec0-82be-48e756aafc46" }
                });
        }
    }
}
