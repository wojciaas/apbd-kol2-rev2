using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace apbd_kol2ef_rev2.Migrations
{
    /// <inheritdoc />
    public partial class AddedDataToTables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Utwor",
                columns: new[] { "IdUtwor", "CzasTrwania", "IdAlbum", "NazwaUtworu" },
                values: new object[,]
                {
                    { 5, 7.5, 3, "Utwor5" },
                    { 6, 8.5, 3, "Utwor6" }
                });

            migrationBuilder.InsertData(
                table: "WykonawcaUtworu",
                columns: new[] { "IdMuzyk", "IdUtwor" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 6);
        }
    }
}
