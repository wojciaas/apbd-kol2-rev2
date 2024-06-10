using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace apbd_kol2ef_rev2.Migrations
{
    /// <inheritdoc />
    public partial class AddedDataToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Muzyk",
                columns: new[] { "IdMuzyk", "Imie", "Nazwisko", "Pseudonim" },
                values: new object[,]
                {
                    { 1, "Jan", "Kowalski", "Kowal" },
                    { 2, "Anna", "Nowak", "Nowa" },
                    { 3, "Piotr", "Wiśniewski", "Wiśnia" }
                });

            migrationBuilder.InsertData(
                table: "Wytwornia",
                columns: new[] { "IdWytwornia", "Nazwa" },
                values: new object[,]
                {
                    { 1, "Universal Music Group" },
                    { 2, "Sony Music Entertainment" },
                    { 3, "Warner Music Group" }
                });

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "IdAlbum", "DataWydania", "IdWytwornia", "NazwaAlbumu" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Album1" },
                    { 2, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Album2" },
                    { 3, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Album3" }
                });

            migrationBuilder.InsertData(
                table: "Utwor",
                columns: new[] { "IdUtwor", "CzasTrwania", "IdAlbum", "NazwaUtworu" },
                values: new object[,]
                {
                    { 1, 3.5, 1, "Utwor1" },
                    { 2, 4.5, 1, "Utwor2" },
                    { 3, 5.5, 2, "Utwor3" },
                    { 4, 6.5, 2, "Utwor4" }
                });

            migrationBuilder.InsertData(
                table: "WykonawcaUtworu",
                columns: new[] { "IdMuzyk", "IdUtwor" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "IdAlbum",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "WykonawcaUtworu",
                keyColumns: new[] { "IdMuzyk", "IdUtwor" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Muzyk",
                keyColumn: "IdMuzyk",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Muzyk",
                keyColumn: "IdMuzyk",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Muzyk",
                keyColumn: "IdMuzyk",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utwor",
                keyColumn: "IdUtwor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Wytwornia",
                keyColumn: "IdWytwornia",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "IdAlbum",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Album",
                keyColumn: "IdAlbum",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Wytwornia",
                keyColumn: "IdWytwornia",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wytwornia",
                keyColumn: "IdWytwornia",
                keyValue: 2);
        }
    }
}
