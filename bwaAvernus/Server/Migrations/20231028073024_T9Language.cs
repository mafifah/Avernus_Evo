using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bwaAvernus.Server.Migrations
{
    /// <inheritdoc />
    public partial class T9Language : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T9Language",
                columns: table => new
                {
                    IdForm = table.Column<long>(type: "bigint", nullable: false),
                    Control = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Bahasa = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    English = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Chinese = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T9Language", x => new { x.IdForm, x.Control });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T9Language");
        }
    }
}
