using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_jab468.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<string>(nullable: false),
                    DirectorFirstName = table.Column<string>(nullable: false),
                    DirectorLastName = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Rating", "Title", "Year", "notes" },
                values: new object[] { 1, "Action", "Johnny", "Appleseed", false, null, "R", "Fast and Furious", "1911", null });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Rating", "Title", "Year", "notes" },
                values: new object[] { 2, "Action", "Johnny", "Appleseed", false, null, "R", "Fast and Furious 2", "1912", null });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Rating", "Title", "Year", "notes" },
                values: new object[] { 3, "Action", "Johnny", "Appleseed", false, null, "R", "Fast and Furious 3", "1913", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
