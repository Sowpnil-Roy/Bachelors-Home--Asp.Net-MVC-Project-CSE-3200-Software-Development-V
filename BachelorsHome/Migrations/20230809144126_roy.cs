using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BachelorsHome.Migrations
{
    public partial class roy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDatabase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    BloodGroup = table.Column<string>(nullable: true),
                    NumberOfPosts = table.Column<int>(nullable: false),
                    NumberOfReviews = table.Column<int>(nullable: false),
                    Connections = table.Column<int>(nullable: false),
                    DateofBirth = table.Column<DateTime>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true),
                    Hobby = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    ReligiousViews = table.Column<string>(nullable: true),
                    PoliticalInterest = table.Column<string>(nullable: true),
                    CurrentAddress = table.Column<string>(nullable: true),
                    AboutMe = table.Column<string>(nullable: true),
                    ProfessionalInterest = table.Column<string>(nullable: true),
                    PermanentAddress = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Rating = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDatabase", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDatabase");
        }
    }
}
