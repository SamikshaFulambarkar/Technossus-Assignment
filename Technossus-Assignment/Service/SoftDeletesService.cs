using Technossus_Assignment.Models;
using Technossus_Assignment.Repository;

namespace Technossus_Assignment.Service
{
    public class SoftDeletesService : ISoftDeletesService
    {
        private readonly ISoftDeletesRepository repo;
        public SoftDeletesService(ISoftDeletesRepository repo)
        {
            this.repo = repo;
        }
        public int AddSoftDeletes(SoftDeletes sd)
        {
            return repo.AddSoftDeletes(sd);
        }

        public int DeleteSoftDeletes(int id)
        {
            return repo.DeleteSoftDeletes(id);
        }

        public IEnumerable<SoftDeletes> GetAllSoftDeletes()
        {
            return repo.GetAllSoftDeletes();
        }

        public SoftDeletes GetSoftDeletesById(int id)
        {
            return repo.GetSoftDeletesById(id);
        }

        public int UpdateSoftDeletes(SoftDeletes sd)
        {
            return repo.UpdateSoftDeletes(sd);
        }
    }
}
