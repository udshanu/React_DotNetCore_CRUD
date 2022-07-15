using React.Entities.Data;
using React.Service.Interfaces;

namespace React.Service
{
    public class CommonService : ICommonService
    {
        private readonly AppDbContext _dbContext;

        public CommonService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool SaveChanges()
        {
            return (_dbContext.SaveChanges() >= 0);
        }
    }
}
