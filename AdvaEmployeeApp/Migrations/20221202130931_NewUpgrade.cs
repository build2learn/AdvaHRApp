using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvaEmployeeApp.Migrations
{
    /// <inheritdoc />
    public partial class NewUpgrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee_DepartmentManagerID",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_DepartmentManagerID",
                schema: "dbo",
                table: "Department");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentManagerID",
                schema: "dbo",
                table: "Department",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Department_DepartmentManagerID",
                schema: "dbo",
                table: "Department",
                column: "DepartmentManagerID",
                unique: true,
                filter: "[DepartmentManagerID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee_DepartmentManagerID",
                schema: "dbo",
                table: "Department",
                column: "DepartmentManagerID",
                principalSchema: "dbo",
                principalTable: "Employee",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee_DepartmentManagerID",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_DepartmentManagerID",
                schema: "dbo",
                table: "Department");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentManagerID",
                schema: "dbo",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_DepartmentManagerID",
                schema: "dbo",
                table: "Department",
                column: "DepartmentManagerID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee_DepartmentManagerID",
                schema: "dbo",
                table: "Department",
                column: "DepartmentManagerID",
                principalSchema: "dbo",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
