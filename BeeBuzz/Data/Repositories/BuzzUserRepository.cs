using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class BuzzUserRepository : BeeBuzzGenericGenericRepository<user>, IUserRepo
    {
        public BuzzUserRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<user>> logger) : base(db, logger)
        {

        }
    }
}
