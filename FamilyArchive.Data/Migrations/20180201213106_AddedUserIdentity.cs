using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FamilyArchive.Data.Migrations
{
    public partial class AddedUserIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Phrase",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int4", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bool", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bool", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    PasswordHash = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bool", nullable: false),
                    SecurityStamp = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bool", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp", nullable: false),
                    UserName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Updated = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Phrase",
                newName: "Guid");
        }
    }
}
