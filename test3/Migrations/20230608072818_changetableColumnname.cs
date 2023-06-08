using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace test3.Migrations
{
    /// <inheritdoc />
    public partial class changetableColumnname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId",
                table: "Actor_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Movies_MovieId",
                table: "Actor_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e40b7c53-279a-4d07-a84b-f5344a085e64", "941c6c24-06b3-46ae-b456-66f17d3ca916" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e65ba61e-fccd-4a68-a57f-d130da83a583", "b26e1e24-989f-4bb5-b3b7-bbf9923de71f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e40b7c53-279a-4d07-a84b-f5344a085e64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65ba61e-fccd-4a68-a57f-d130da83a583");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "941c6c24-06b3-46ae-b456-66f17d3ca916");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b26e1e24-989f-4bb5-b3b7-bbf9923de71f");

            migrationBuilder.RenameTable(
                name: "Actor_Movies",
                newName: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Producers",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "PullName",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Movies",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureUrl",
                table: "Actors",
                newName: "ProfilePictureURL");

            migrationBuilder.RenameColumn(
                name: "PullName",
                table: "Actors",
                newName: "FullName");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_Movies_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies");

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

            migrationBuilder.RenameTable(
                name: "Actors_Movies",
                newName: "Actor_Movies");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Producers",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "PullName");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Movies",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProfilePictureUrl");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "PullName");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actor_Movies",
                newName: "IX_Actor_Movies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e40b7c53-279a-4d07-a84b-f5344a085e64", null, "Member", "MEMBER" },
                    { "e65ba61e-fccd-4a68-a57f-d130da83a583", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "941c6c24-06b3-46ae-b456-66f17d3ca916", 0, "37138297-f2f0-48ff-9360-3c60d2c20e03", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEADpDFiuFb2JuCujOvY2jECQ24RFk3Kw0LDsHG+DR2L8CneNk/p+So1Y2Omw0TJTNQ==", null, false, "32c397a7-3052-4f80-bba1-dd5f16e54726", false, "mm@mm.mm" },
                    { "b26e1e24-989f-4bb5-b3b7-bbf9923de71f", 0, "89113fe3-e628-4fe7-b32e-4fb86eb31ec0", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAECVa0KsG5XxraUzMoW1vXpj3oPBneuBjCp5hzlGa13n4wCGgG8Worg2sq1PjPCbh5w==", null, false, "900e186a-d52b-48db-84dc-cc98d7b8447c", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e40b7c53-279a-4d07-a84b-f5344a085e64", "941c6c24-06b3-46ae-b456-66f17d3ca916" },
                    { "e65ba61e-fccd-4a68-a57f-d130da83a583", "b26e1e24-989f-4bb5-b3b7-bbf9923de71f" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_ActorId",
                table: "Actor_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Movies_MovieId",
                table: "Actor_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
