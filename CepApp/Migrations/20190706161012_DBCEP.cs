using Microsoft.EntityFrameworkCore.Migrations;

namespace CepApp.Migrations
{
    public partial class DBCEP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CEPS",
                table: "CEPS");

            migrationBuilder.RenameTable(
                name: "CEPS",
                newName: "CEP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CEP",
                table: "CEP",
                column: "CepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CEP",
                table: "CEP");

            migrationBuilder.RenameTable(
                name: "CEP",
                newName: "CEPS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CEPS",
                table: "CEPS",
                column: "CepId");
        }
    }
}
