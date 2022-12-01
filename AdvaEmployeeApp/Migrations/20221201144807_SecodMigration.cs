using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdvaEmployeeApp.Migrations
{
    /// <inheritdoc />
    public partial class SecodMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_departmentID",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "salary",
                schema: "dbo",
                table: "Employee",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "employeeName",
                schema: "dbo",
                table: "Employee",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "departmentID",
                schema: "dbo",
                table: "Employee",
                newName: "DepartmentID");

            migrationBuilder.RenameColumn(
                name: "employeeId",
                schema: "dbo",
                table: "Employee",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_departmentID",
                schema: "dbo",
                table: "Employee",
                newName: "IX_Employee_DepartmentID");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                schema: "dbo",
                table: "Employee",
                type: "Decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Deccimal(12,2)");

            migrationBuilder.AddColumn<int>(
                name: "ManagerID",
                schema: "dbo",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentManagerID",
                schema: "dbo",
                table: "Department",
                type: "int",
                nullable: false);

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
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentID",
                schema: "dbo",
                table: "Employee",
                column: "DepartmentID",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee_DepartmentManagerID",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentID",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Department_DepartmentManagerID",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "ManagerID",
                schema: "dbo",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DepartmentManagerID",
                schema: "dbo",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "Salary",
                schema: "dbo",
                table: "Employee",
                newName: "salary");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                schema: "dbo",
                table: "Employee",
                newName: "employeeName");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                schema: "dbo",
                table: "Employee",
                newName: "departmentID");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                schema: "dbo",
                table: "Employee",
                newName: "employeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DepartmentID",
                schema: "dbo",
                table: "Employee",
                newName: "IX_Employee_departmentID");

            migrationBuilder.AlterColumn<decimal>(
                name: "salary",
                schema: "dbo",
                table: "Employee",
                type: "Deccimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(12,2)");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_departmentID",
                schema: "dbo",
                table: "Employee",
                column: "departmentID",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
