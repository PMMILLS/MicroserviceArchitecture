using DomainLayer.Models;
using PersistenceLayer.Models;

namespace DomainLayer.Business.Interfaces
{
    public interface IBuildDomainModel
    {
        DomainModel BuildDomainModelData();
    }
}
