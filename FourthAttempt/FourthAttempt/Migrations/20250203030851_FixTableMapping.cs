using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourthAttempt.Migrations
{
    /// <inheritdoc />
    public partial class FixTableMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entries",
                table: "Entries");

            migrationBuilder.RenameTable(
                name: "Entries",
                newName: "entries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_entries",
                table: "entries",
                column: "SiteEntryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_entries",
                table: "entries");

            migrationBuilder.RenameTable(
                name: "entries",
                newName: "Entries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entries",
                table: "Entries",
                column: "SiteEntryID");
        }
    }
}
