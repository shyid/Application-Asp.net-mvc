using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class addtabele_orderandorderitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orderItems_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderItems_Orders_UserId",
                        column: x => x.UserId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_MovieId",
                table: "orderItems",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_OrderId",
                table: "orderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_UserId",
                table: "orderItems",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderItems");

            migrationBuilder.DropTable(
                name: "Orders");

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
    }
}
