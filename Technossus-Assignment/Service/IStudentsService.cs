using Technossus_Assignment.Models;

namespace Technossus_Assignment.Service
{
    public interface IStudentsService
    {
        IEnumerable<Students> GetAllStudents();
        Students GetStudentsById(int id);
        int AddStudents(Students st);
        int UpdateStudents(Students st);
        int DeleteStudents(int id);
    }
}
