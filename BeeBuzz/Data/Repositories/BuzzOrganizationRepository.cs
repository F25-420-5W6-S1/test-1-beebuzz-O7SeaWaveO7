using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;
using Microsoft.Identity.Client;

namespace BeeBuzz.Data.Repositories
{
    public class BuzzOrganizationRepository : BeeBuzzGenericGenericRepository<Organization>, IOrganizationRepo
    {
        public BuzzOrganizationRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Organization>> logger) : base(db, logger)
        {

        }
        public IEnumerable<Organization> getAllUsers(int organizationId)
        {
            return _dbSet
                .Where(p => p.Id == organizationId);
                
        }
        public IEnumerable<Organization> getAllBeeHives(int organizationId)
        {
            return _dbSet
                .Where(p => p.Id == organizationId)
                .Join(
                .Select(p =>
                {
                    
                }); 
        }


    }
}
