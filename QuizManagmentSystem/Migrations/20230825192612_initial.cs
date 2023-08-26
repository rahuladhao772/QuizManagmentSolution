using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizManagmentSystem.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Depatment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "userEntities",
                columns: new[] { "Id", "ConfirmPassword", "Depatment", "Email", "FName", "Gender", "LName", "MName", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "rahul123", "Mechanical", "rahul@gmail.com", "Rahul", "Male", "Adhao", "Sheshrao", "rahul123", "7499458965" },
                    { 2, "neha123", "CS", "neha@gmail.com", "Neha", "Female", "Ahire", "Bhaskar", "neha123", "9605000860" },
                    { 3, "Mansi123", "CS", "Mansi@gmail.com", "Mansi", "Female", "Goavkar", "Vithaldas", "Mansi123", "9604086056" },
                    { 4, "Niraj123", "Mechanical", "Nirnjan@gmail.com", "Nirnjan", "Male", "Khatave", "Anil", "Niraj123", "7499458965" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userEntities");
        }
    }
}
