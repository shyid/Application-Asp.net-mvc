using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class updateActorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureURL",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c9061dc-2a9e-4be3-99b4-822d7498567e", null, "Member", "MEMBER" },
                    { "a12901af-011c-452c-b4e3-d77be8b555f8", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d2f8f473-c500-4f1e-8649-f906ae7435f0", 0, "a3c20392-1fc6-4b1f-aa94-fe4272ce716e", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEBPKF6TbkNzcY/dELL/ZJoVyor8G2Bq5mZeDZ+pMs4e7Zr8BiuZyRrxaGQ6VEnVqbw==", null, false, "67c4e143-805f-4859-a59d-601e48b89d35", false, "aa@aa.aa" },
                    { "ea6110a8-f58e-4dcb-aadd-bf043e0d26c9", 0, "39a7cbab-5419-403d-b3c5-6b90b8b22bc1", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEE6W1rLjmywB4NM6Wd8aCEUtN7o4hz6R/OTbygkHjA9D3GYFarWIbuzitejcMMO/JQ==", null, false, "43b1e3b9-371c-46fe-83df-54f0714fe64b", false, "mm@mm.mm" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a12901af-011c-452c-b4e3-d77be8b555f8", "d2f8f473-c500-4f1e-8649-f906ae7435f0" },
                    { "2c9061dc-2a9e-4be3-99b4-822d7498567e", "ea6110a8-f58e-4dcb-aadd-bf043e0d26c9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a12901af-011c-452c-b4e3-d77be8b555f8", "d2f8f473-c500-4f1e-8649-f906ae7435f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c9061dc-2a9e-4be3-99b4-822d7498567e", "ea6110a8-f58e-4dcb-aadd-bf043e0d26c9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c9061dc-2a9e-4be3-99b4-822d7498567e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a12901af-011c-452c-b4e3-d77be8b555f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2f8f473-c500-4f1e-8649-f906ae7435f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea6110a8-f58e-4dcb-aadd-bf043e0d26c9");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureURL",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
