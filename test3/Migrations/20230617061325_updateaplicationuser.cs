using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class updateaplicationuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "33dfa9e2-9892-4c94-bf86-5a4712ec47e6", null, "Member", "MEMBER" },
                    { "f1584772-acc2-44ca-82fd-fb03b3452587", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6ec4e28c-a168-4100-9d20-3b97bd21eb0b", 0, "90f5ee42-4361-41fb-b3a8-c77bd71a531a", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEHcZVTOF7HVGM1QHyYgIlg5bWW6wVEy6Nx3MBvgmp7kEPrS2jXmvViptxMMUDvPncQ==", null, false, "f879df0a-ae21-4e43-adf6-7dec2c6e6ba4", false, "mm@mm.mm" },
                    { "7afcf0de-f097-41b7-b10f-5be846cbef45", 0, "cbcc9e5b-3a5a-474d-b238-94500d1e1933", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEABCGyD/3V82a3As6HOFegYdFZfsziF6czZLW2gTEwIQCKzkDbLOQ5/4osxPjCMEFg==", null, false, "589dfe9b-7a57-4996-bb4b-62f84c34c20b", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "33dfa9e2-9892-4c94-bf86-5a4712ec47e6", "6ec4e28c-a168-4100-9d20-3b97bd21eb0b" },
                    { "f1584772-acc2-44ca-82fd-fb03b3452587", "7afcf0de-f097-41b7-b10f-5be846cbef45" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33dfa9e2-9892-4c94-bf86-5a4712ec47e6", "6ec4e28c-a168-4100-9d20-3b97bd21eb0b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f1584772-acc2-44ca-82fd-fb03b3452587", "7afcf0de-f097-41b7-b10f-5be846cbef45" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33dfa9e2-9892-4c94-bf86-5a4712ec47e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1584772-acc2-44ca-82fd-fb03b3452587");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ec4e28c-a168-4100-9d20-3b97bd21eb0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7afcf0de-f097-41b7-b10f-5be846cbef45");

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
    }
}
