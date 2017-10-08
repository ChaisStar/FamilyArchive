using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FamilyArchive.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phrase",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    From = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Text = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    To = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Updated = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phrase", x => x.Guid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phrase");
        }
    }
}
