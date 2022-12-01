namespace AdvaEmployeeApp.Models
{
    [Table("Department", Schema ="dbo")]

    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="Department ID")]
        public int DepartmentId { get; set; }

        [Required]
        [Column(TypeName="Varchar(150)")]
        [Display(Name="Department Name")]
        public string? DepartmentName { get; set; }

        [Required]
        [ForeignKey("Manager")]
        public int DepartmentManagerID { get; set; }

        [Display(Name = "ManagerName")]
        [NotMapped]
        public int DepartmentManagerName { get; set; }

        public virtual Manager DepartmentManager { get; set; }
       
    }
}
