using PersistenceLayer.Context.Interfaces;
using PersistenceLayer.Models;

namespace PersistenceLayer.Context.Implementations
{
    public class GetPersistanceModel : IGetPersistanceModel
    {
        PersistanceModel IGetPersistanceModel.GetPersistanceModel()
        {
            return new PersistanceModel { Text = "This is from the persistance layer" };
        }
    }
}
