using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class BuzzHiveRepository : BeeBuzzGenericGenericRepository<beeHive>, IBeeHiveRepo
    {
        public BuzzHiveRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<beeHive>> logger) : base(db, logger)
        {

        }

    }
}
