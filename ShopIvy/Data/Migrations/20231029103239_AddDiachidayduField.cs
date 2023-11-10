using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopIvy.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDiachidayduField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiaChiDayDu",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiaChiDayDu",
                table: "AspNetUsers");
        }
    }
}
