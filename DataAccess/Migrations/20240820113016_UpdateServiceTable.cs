using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateServiceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Testimonials",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Teams",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Services",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Projects",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Products",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ProductCategories",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Packages",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "PackagePricings",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "News",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Messages",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Contacts",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Comments",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Categories",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Abouts",
                newName: "IsDeleted");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Pricings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Pricings");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Testimonials",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Teams",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Services",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Projects",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Products",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "ProductCategories",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Packages",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "PackagePricings",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "News",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Messages",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Contacts",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Comments",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Categories",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Abouts",
                newName: "Status");
        }
    }
}
