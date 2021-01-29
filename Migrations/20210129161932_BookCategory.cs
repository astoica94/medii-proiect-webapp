using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class BookCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "ITask",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TaskItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITaskID = table.Column<int>(nullable: false),
                    TaskText = table.Column<string>(nullable: true),
                    TaskDone = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaskItem_ITask_ITaskID",
                        column: x => x.ITaskID,
                        principalTable: "ITask",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ITask_AuthorID",
                table: "ITask",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_ITaskID",
                table: "TaskItem",
                column: "ITaskID");

            migrationBuilder.AddForeignKey(
                name: "FK_ITask_Author_AuthorID",
                table: "ITask",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ITask_Author_AuthorID",
                table: "ITask");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "TaskItem");

            migrationBuilder.DropIndex(
                name: "IX_ITask_AuthorID",
                table: "ITask");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "ITask");
        }
    }
}
