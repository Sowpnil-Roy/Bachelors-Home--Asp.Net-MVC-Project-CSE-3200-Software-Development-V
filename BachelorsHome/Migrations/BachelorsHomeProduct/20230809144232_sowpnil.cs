using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BachelorsHome.Migrations.BachelorsHomeProduct
{
    public partial class sowpnil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserPic = table.Column<string>(nullable: true),
                    OppoId = table.Column<int>(nullable: false),
                    OppoName = table.Column<string>(nullable: true),
                    OppoPic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommentModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(nullable: true),
                    PostId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Editcnt = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserPic = table.Column<string>(nullable: true),
                    NowTime = table.Column<string>(nullable: true),
                    CommentTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistrictModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionName = table.Column<string>(nullable: true),
                    DistrictName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistrictModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DivisionModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivisionModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Division = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Thana = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NoOfComments = table.Column<int>(nullable: false),
                    RoomSize = table.Column<string>(nullable: true),
                    AvailableSeat = table.Column<int>(nullable: false),
                    SeatRent = table.Column<int>(nullable: false),
                    TotalCost = table.Column<int>(nullable: false),
                    InternetFacility = table.Column<string>(nullable: true),
                    FoodFacility = table.Column<string>(nullable: true),
                    AttachedWashroom = table.Column<string>(nullable: true),
                    AttachedBalcony = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    Heading = table.Column<string>(nullable: true),
                    AvailableFrom = table.Column<DateTime>(nullable: true),
                    FloorNumber = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ReviewerId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Value = table.Column<double>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    ReviewerPic = table.Column<string>(nullable: true),
                    ReviewerName = table.Column<string>(nullable: true),
                    UserPic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThanaModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(nullable: true),
                    ThanaName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanaModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "CommentModel");

            migrationBuilder.DropTable(
                name: "DistrictModel");

            migrationBuilder.DropTable(
                name: "DivisionModel");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ThanaModel");
        }
    }
}
