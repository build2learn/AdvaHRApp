namespace AdvaEmployeeApp.Models
{
    [Table("Department", Schema ="dbo")]

    public class Department
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="Department ID")]
        public int DepartmentId { get; set; }

        [Required]
        [Column(TypeName="Varchar(150)")]
        [Display(Name="Department Name")]
        public string? DepartmentName { get; set; }

        [ForeignKey("DeptManager")]
        public int? DepartmentManagerID { get; set; } = 0;
        [Display(Name = "Department Manager")]

        public virtual Employee? DeptManager { get; set; }


        //[Display(Name = "Department Manager")]
        //[NotMapped]
        //public string? DepartmentManager { get { return DeptManager?.EmployeeName; }/*; set; */}


    }
}
