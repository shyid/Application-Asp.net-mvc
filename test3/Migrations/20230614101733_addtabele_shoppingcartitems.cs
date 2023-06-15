using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class addtabele_shoppingcartitems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3684ac6-c96d-4478-8c9e-225f5bbc2600", "49550163-bccf-4a66-9090-1211df868276" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0201734-2a36-4473-b942-45c9b0b1726e", "f095dacc-5a23-4b1d-870c-834b9e53a09f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0201734-2a36-4473-b942-45c9b0b1726e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3684ac6-c96d-4478-8c9e-225f5bbc2600");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49550163-bccf-4a66-9090-1211df868276");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f095dacc-5a23-4b1d-870c-834b9e53a09f");

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_MovieId",
                table: "ShoppingCartItems",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

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
                    { "c0201734-2a36-4473-b942-45c9b0b1726e", null, "Member", "MEMBER" },
                    { "d3684ac6-c96d-4478-8c9e-225f5bbc2600", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "49550163-bccf-4a66-9090-1211df868276", 0, "e8c3dd5b-7d3f-47af-8281-06d7915b99ba", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEEz3aOk5e3W4wjnZWnMiFIYafjEyjBslwvzukPpNjlePtPfsTE0c25vjNvw3w9mioA==", null, false, "5d8937c5-264f-4db5-a670-85aa32e2fc01", false, "aa@aa.aa" },
                    { "f095dacc-5a23-4b1d-870c-834b9e53a09f", 0, "cb42b0cb-9bc0-4356-a814-59a1ca8dda83", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEN3gq2o3/CUclH1+Ut3uFb2VM42cFUnUMwKdF39yhvJODxM3xUdzRLT7j8o+VJLjJw==", null, false, "33bc0475-9d68-40d3-85ba-540d73402ce2", false, "mm@mm.mm" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d3684ac6-c96d-4478-8c9e-225f5bbc2600", "49550163-bccf-4a66-9090-1211df868276" },
                    { "c0201734-2a36-4473-b942-45c9b0b1726e", "f095dacc-5a23-4b1d-870c-834b9e53a09f" }
                });
        }
    }
}
