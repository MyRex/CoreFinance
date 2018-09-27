using Microsoft.EntityFrameworkCore.Migrations;

namespace ZFine.Web.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "F_EnCode",
                table: "Sys_ItemsDetail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "F_EnCode",
                table: "Sys_ItemsDetail");
        }
    }
}
