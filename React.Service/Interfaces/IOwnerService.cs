using React.Entities.Models;

namespace React.Service.Interfaces
{
    public interface IOwnerService
    {
        IEnumerable<Owner> GetAllOwnerInformation();
        Owner GetOwnerById(int id);
        void CreateOwner(Owner owner);
    }
}
