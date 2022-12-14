// <auto-generated />
using System;
using AdvaEmployeeApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdvaEmployeeApp.Migrations
{
    [DbContext(typeof(HRDBContext))]
    [Migration("20221202130931_NewUpgrade")]
    partial class NewUpgrade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdvaEmployeeApp.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<int?>("DepartmentManagerID")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.HasKey("DepartmentId");

                    b.HasIndex("DepartmentManagerID")
                        .IsUnique()
                        .HasFilter("[DepartmentManagerID] IS NOT NULL");

                    b.ToTable("Department", "dbo");
                });

            modelBuilder.Entity("AdvaEmployeeApp.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(150)");

                    b.Property<int?>("ManagerID")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("Decimal(12,2)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employee", "dbo");
                });

            modelBuilder.Entity("AdvaEmployeeApp.Models.Department", b =>
                {
                    b.HasOne("AdvaEmployeeApp.Models.Employee", "DeptManager")
                        .WithOne()
                        .HasForeignKey("AdvaEmployeeApp.Models.Department", "DepartmentManagerID");

                    b.Navigation("DeptManager");
                });

            modelBuilder.Entity("AdvaEmployeeApp.Models.Employee", b =>
                {
                    b.HasOne("AdvaEmployeeApp.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
