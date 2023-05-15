using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EHR.Domain.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Occupation",
                table: "Usertable",
                newName: "Department");

            migrationBuilder.AddColumn<double>(
                name: "Fee",
                table: "Usertable",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "Usertable");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Usertable",
                newName: "Occupation");
        }
    }
}
