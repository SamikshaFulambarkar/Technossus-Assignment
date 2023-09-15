using Technossus_Assignment.Models;
using Technossus_Assignment.Repository;

namespace Technossus_Assignment.Service
{
    public class StudentsService : IStudentsService
    {
        private readonly IStudentsRepository repo;
        public StudentsService(IStudentsRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudents(Students st)
        {
            return repo.AddStudents(st);
        }

        public int DeleteStudents(int id)
        {
            return repo.DeleteStudents(id);
        }

        public IEnumerable<Students> GetAllStudents()
        {
            return repo.GetAllStudents();
        }

        public Students GetStudentsById(int id)
        {
            return repo.GetStudentsById(id);
        }

        public int UpdateStudents(Students st)
        {
            return repo.UpdateStudents(st);
        }
    }
}
