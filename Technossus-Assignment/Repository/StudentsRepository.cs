using Technossus_Assignment.Models;

namespace Technossus_Assignment.Repository
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly ApplicationDbContext db;
        public StudentsRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddStudents(Students st)
        {
            int result = 0;
            db.students.Add(st);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteStudents(int id)
        {
            int result = 0;
            var st = db.students.Where(x => x.Id == id).FirstOrDefault();
            if (st != null)
            {
                db.students.Remove(st);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Students> GetAllStudents()
        {
            return db.students.ToList();
        }

        public Students GetStudentsById(int id)
        {
            var st = db.students.Where(x => x.Id == id).FirstOrDefault();
            return st;
        }

        public int UpdateStudents(Students st)
        {
            int result = 0;
            var s = db.students.Where(x => x.Id == st.Id).FirstOrDefault();
            if (s != null)
            {
                s.StudentName = st.StudentName;
                s.FatherName = st.FatherName;
                s.MotherName = st.MotherName;
                s.Age = st.Age;
                s.HomeAddress = st.HomeAddress;
                s.RegistrationDate = st.RegistrationDate;
                s.IsDeleted = st.IsDeleted;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
