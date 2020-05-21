using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CreamConsulting.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityCardMembers",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false),
                    IdentityCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityCardMembers", x => new { x.MemberId, x.IdentityCardId });
                });

            migrationBuilder.CreateTable(
                name: "IdentityCards",
                columns: table => new
                {
                    IdentityCardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SocialSecurityId = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false),
                    ValidUntil = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityCards", x => x.IdentityCardId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberCardNumber = table.Column<string>(nullable: true),
                    Emailaddress = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    IsBlackListed = table.Column<bool>(nullable: false),
                    BlackListeduntil = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityCardMembers");

            migrationBuilder.DropTable(
                name: "IdentityCards");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
