using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnEfCore.Migrations
{
    /// <inheritdoc />
    public partial class AddCodeToStudentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Students");
        }
    }
}
