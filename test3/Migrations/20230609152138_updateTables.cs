using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class updateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Producers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Cinemas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Discription",
                table: "Cinemas",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureURL",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Producers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Discription",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
