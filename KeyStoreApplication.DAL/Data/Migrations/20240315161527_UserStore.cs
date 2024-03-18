using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KeyStoreApplication.Data.Migrations
{
    public partial class UserStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Keystore",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Userstore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userstore", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Keystore_UserId",
                table: "Keystore",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Keystore_Userstore_UserId",
                table: "Keystore",
                column: "UserId",
                principalTable: "Userstore",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keystore_Userstore_UserId",
                table: "Keystore");

            migrationBuilder.DropTable(
                name: "Userstore");

            migrationBuilder.DropIndex(
                name: "IX_Keystore_UserId",
                table: "Keystore");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Keystore");
        }
    }
}
