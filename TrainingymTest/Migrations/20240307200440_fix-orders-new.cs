using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingymTest.Migrations
{
    /// <inheritdoc />
    public partial class fixordersnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dateOrder",
                table: "Orders",
                newName: "DateOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOrder",
                table: "Orders",
                newName: "dateOrder");
        }
    }
}
