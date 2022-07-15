using React.Entities.Data;
using React.Entities.Models;
using React.Service.Interfaces;

namespace React.Service
{
    public class OwnerService : IOwnerService
    {
        private readonly AppDbContext _dbContext;

        public OwnerService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateOwner(Owner owner)
        {
            if (owner == null)
            {
                throw new ArgumentNullException(nameof(owner));
            }

            _dbContext.Owners.Add(owner);
        }

        public IEnumerable<Owner> GetAllOwnerInformation()
        {
            return _dbContext.Owners.ToList();
        }

        public Owner GetOwnerById(int id)
        {
            return _dbContext.Owners.FirstOrDefault(x => x.Id == id);
        }
    }
}
