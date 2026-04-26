namespace CRUD_Operations.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        // Navigation property for Students in this department
        public ICollection<Student> Students { get; set; }
    }
}
