namespace AdvaEmployeeApp.Models
{
    [Table("Employee",Schema ="dbo")]
    public class Employee
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Employee Name")]
        [Column(TypeName ="Varchar(150)")]
        [MaxLength(100)]
        public string? EmployeeName { get; set; }

        [Required]
        [Display(Name = "Salary")]
        [Column(TypeName = "Decimal(12,2)")]
        public decimal Salary { get; set; }

        [Required]
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
         
        [Display(Name ="Department")]
        [NotMapped]
        public string? DepartmentName { get; set; }

        public virtual Department? Department { get; set; }


    }
}
