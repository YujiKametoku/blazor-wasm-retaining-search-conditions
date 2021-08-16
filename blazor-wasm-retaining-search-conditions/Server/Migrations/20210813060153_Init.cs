using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace blazorwasmretainingsearchconditions.Server.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Email", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 1L, 36, "avril@avril.com", "Avril", "WOMEN", "Lavigne" },
                    { 2L, 35, "bruno@bruno.com", "Bruno", "MEN", "Mars" },
                    { 3L, 29, "charlie@charlie.com", "Charlie", "MEN", "Puth" },
                    { 4L, 30, "ed@ed.com", "Ed", "MEN", "Sheeran" },
                    { 5L, 30, "james@james.com", "James", "MEN", "Bay" },
                    { 6L, 31, "jess@jess.com", "Jess", "WOMEN", "Glynne" },
                    { 7L, 36, "katy@katy.com", "Katy", "WOMEN", "Perry" },
                    { 8L, 35, "gaga@gaga.com", "Lady", "WOMEN", "Gaga" },
                    { 9L, 50, "michael@michael.com", "Michael", "MEN", "Jackson" },
                    { 10L, 29, "sam@sam.com", "Sam", "MEN", "Smith" }
                });
        }

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "Students");
        //}
    }
}
