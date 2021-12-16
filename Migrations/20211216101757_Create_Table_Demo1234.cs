using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo1234.Migrations
{
    public partial class Create_Table_Demo1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonDemo1234",
                table: "PersonDemo1234");

            migrationBuilder.RenameTable(
                name: "PersonDemo1234",
                newName: "Person");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "PersonID");

            migrationBuilder.CreateTable(
                name: "Demo",
                columns: table => new
                {
                    DemoID = table.Column<string>(type: "TEXT", nullable: false),
                    DemoName = table.Column<string>(type: "TEXT", nullable: true),
                    DemoGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demo", x => x.DemoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "PersonDemo1234");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonDemo1234",
                table: "PersonDemo1234",
                column: "PersonID");
        }
    }
}
