namespace Technossus_Assignment.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int Age { get; set; }
        public string HomeAddress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsDeleted { get; set; }

    }
    public class SoftDeletes
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public int RecordId { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}
