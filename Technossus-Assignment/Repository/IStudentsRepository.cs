using Technossus_Assignment.Models;

namespace Technossus_Assignment.Repository
{
    public interface IStudentsRepository
    {
        IEnumerable<Students> GetAllStudents();
        Students GetStudentsById(int id);
        int AddStudents(Students st);
        int UpdateStudents(Students st);
        int DeleteStudents(int id);
    }
}
