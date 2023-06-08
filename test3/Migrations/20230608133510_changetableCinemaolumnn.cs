using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class changetableCinemaolumnn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2765d4df-a80e-41ec-a06d-9671237a0861", "4f5ff6f3-0164-4a62-86d2-2e08c110d593" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f57871f1-ce16-4d5b-a8a2-c6f80e0be0c5", "56bed21f-7042-4e22-9e62-e2520ae1fe5d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2765d4df-a80e-41ec-a06d-9671237a0861");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f57871f1-ce16-4d5b-a8a2-c6f80e0be0c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5ff6f3-0164-4a62-86d2-2e08c110d593");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56bed21f-7042-4e22-9e62-e2520ae1fe5d");

            migrationBuilder.RenameColumn(
                name: "PullName",
                table: "Cinemas",
                newName: "FullName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b7107ce-2e95-48a6-aad4-da739513b652", null, "Admin", "ADMIN" },
                    { "b6eac358-9a1d-4746-825c-c08b2550f6e8", null, "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4a942ef1-6997-471b-9801-5e4e6d76e406", 0, "5e240d60-19b9-4081-8cbb-8ee5364b41a5", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEETkExWzg1uBn9Bhfk+RSpWs3bo4uCG+EZrNwhEwTPir9GRYVfRKBfTGBY/8wNp9+g==", null, false, "6d5ed033-f18b-4d43-9608-05a0bd15ef31", false, "mm@mm.mm" },
                    { "8c1eb37f-a696-4df4-af40-fbfe3e88db6f", 0, "9b042d8d-52fa-4651-a900-184db032c1c7", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEB9DTqnrWmkaqBc5nq8x6MvpOakPDmP6a+Xk9uxpzHLHavlupPy9msBFen9qUdBOeA==", null, false, "e9573764-9564-4e2c-8386-522a71c0a6ae", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b6eac358-9a1d-4746-825c-c08b2550f6e8", "4a942ef1-6997-471b-9801-5e4e6d76e406" },
                    { "2b7107ce-2e95-48a6-aad4-da739513b652", "8c1eb37f-a696-4df4-af40-fbfe3e88db6f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6eac358-9a1d-4746-825c-c08b2550f6e8", "4a942ef1-6997-471b-9801-5e4e6d76e406" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b7107ce-2e95-48a6-aad4-da739513b652", "8c1eb37f-a696-4df4-af40-fbfe3e88db6f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b7107ce-2e95-48a6-aad4-da739513b652");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6eac358-9a1d-4746-825c-c08b2550f6e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a942ef1-6997-471b-9801-5e4e6d76e406");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c1eb37f-a696-4df4-af40-fbfe3e88db6f");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Cinemas",
                newName: "PullName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2765d4df-a80e-41ec-a06d-9671237a0861", null, "Member", "MEMBER" },
                    { "f57871f1-ce16-4d5b-a8a2-c6f80e0be0c5", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f5ff6f3-0164-4a62-86d2-2e08c110d593", 0, "d578a3c4-cf01-482e-95c9-4da58ae565cf", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAECcNSWc3twLkzZeypjx7ZmgLMqMmQxzTeY7hVQgQGudPkgAVFqNXGecwQ2U/p4ocQw==", null, false, "a9bfe231-616e-410c-88cf-546461084651", false, "mm@mm.mm" },
                    { "56bed21f-7042-4e22-9e62-e2520ae1fe5d", 0, "027431aa-cab6-4273-a779-5af6e2f8c7e3", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEL65n1LzrgdwxISiI0gCwydyxdhwq0BRNI7uQUN24LOk2Vjyiv6V0mXDICIbu7fOVA==", null, false, "e0dd1628-c9aa-4a75-9fa9-097221e550af", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2765d4df-a80e-41ec-a06d-9671237a0861", "4f5ff6f3-0164-4a62-86d2-2e08c110d593" },
                    { "f57871f1-ce16-4d5b-a8a2-c6f80e0be0c5", "56bed21f-7042-4e22-9e62-e2520ae1fe5d" }
                });
        }
    }
}
