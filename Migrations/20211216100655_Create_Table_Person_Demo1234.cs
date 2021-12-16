using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo1234.Migrations
{
    public partial class Create_Table_Person_Demo1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonDemo1234",
                columns: table => new
                {
                    PersonID = table.Column<string>(type: "TEXT", nullable: false),
                    PersonName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonDemo1234", x => x.PersonID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonDemo1234");
        }
    }
}
