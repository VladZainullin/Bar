using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cocktails",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cocktails", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "cocktails",
                columns: new[] { "id", "description", "title" },
                values: new object[,]
                {
                    { new Guid("15cc9bde-4698-4786-b11f-b157527d01cd"), "Это один из самых популярных миксов: апельсиновый сок и водка. На выходе коктейль получается очень цитрусовым. Большое количество сока делает \"Отвёртку\" слабоалкогольной, но это не значит, что лонг совершенно безвреден: пара-тройка коктейлей и настоящая отвёртка уже будет выпадать из ваших рук.", "Отвёртка" },
                    { new Guid("3b493e1e-9c2d-49de-b6c5-da9240b4334a"), "Это крепкий кофейно-сливочный коктейль на водке", "Белый русский" },
                    { new Guid("abeeff92-3660-4e5f-9fa3-6ff96d34ca23"), "Это крепкий горький коктейль на основе джина с добавлением биттера и красного вермута. Идеален как в качестве аперитива, так и дижестива. Один из самых популярных коктейлей в мире, потрясающе вкусный и гармоничный. ", "Негрони" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cocktails");
        }
    }
}
