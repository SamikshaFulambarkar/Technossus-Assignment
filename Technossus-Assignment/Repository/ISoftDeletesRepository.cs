using Technossus_Assignment.Models;

namespace Technossus_Assignment.Repository
{
    public interface ISoftDeletesRepository
    {
        IEnumerable<SoftDeletes> GetAllSoftDeletes();
        SoftDeletes GetSoftDeletesById(int id);
        int AddSoftDeletes(SoftDeletes sd);
        int UpdateSoftDeletes(SoftDeletes sd);
        int DeleteSoftDeletes(int id);
    }
}
