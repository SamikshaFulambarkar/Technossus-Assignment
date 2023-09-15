using Technossus_Assignment.Models;

namespace Technossus_Assignment.Repository
{
    public class SoftDeletesRepository : ISoftDeletesRepository
    {
        private readonly ApplicationDbContext db;
        public SoftDeletesRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddSoftdeletes(SoftDeletes sd)
        {
            int result = 0;
            db.softDeletes.Add(sd);
            result = db.SaveChanges();
            return result;
        }

        public int AddSoftDeletes(SoftDeletes sd)
        {
            throw new NotImplementedException();
        }

        public int DeleteSoftDeletes(int id)
        {
            int result = 0;
            var sd = db.softDeletes.Where(x => x.Id == id).FirstOrDefault();
            if (sd != null)
            {
                db.softDeletes.Remove(sd);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<SoftDeletes> GetAllSoftDeletes()
        {
            return db.softDeletes.ToList();
        }

        public SoftDeletes GetSoftDeletesById(int id)
        {
            var sd = db.softDeletes.Where(x => x.Id == id).FirstOrDefault();
            return sd;
        }

        public int UpdateSoftDeletes(SoftDeletes sd)
        {
            int result = 0;
            var d = db.softDeletes.Where(x => x.Id == sd.Id).FirstOrDefault();
            if (d != null)
            {
                d.TableName = sd.TableName;
                d.RecordId = sd.RecordId;
                d.DeletedAt = sd.DeletedAt;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
