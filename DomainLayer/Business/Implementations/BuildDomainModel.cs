using DomainLayer.Business.Interfaces;
using DomainLayer.Models;
using PersistenceLayer.Context.Interfaces;
using PersistenceLayer.Models;
using System;

namespace DomainLayer.Business.Implementations
{
    public class BuildDomainModel : IBuildDomainModel
    {
        private readonly IGetPersistanceModel getPersistanceModel;

        public BuildDomainModel(IGetPersistanceModel getPersistanceModel)
        {
            this.getPersistanceModel = getPersistanceModel;
        }

        public DomainModel BuildDomainModelData()
        {
            PersistanceModel data = getPersistanceModel.GetPersistanceModel();
            DomainModel domainModel = new DomainModel()
            {
                Text = data.Text,
                SecondText = "This is from the domain layer",
                Time = DateTime.Now
            };

            return domainModel;
        }
    }
}
