using AutoMapper;
using DomainLayer.Business.Interfaces;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper mapper;
        private readonly IBuildDomainModel buildDomainModel;

        public HomeController(IMapper mapper, IBuildDomainModel buildDomainModel)
        {
            this.mapper = mapper;
            this.buildDomainModel = buildDomainModel;
        }

        public IActionResult Index()
        {
            DomainModel domainModel = buildDomainModel.BuildDomainModelData();
            var vm = mapper.Map<HomeViewModel>(domainModel);
            vm.ThridText = "Text added in the Presentation layer - for demonstration purpose";

            return View(vm);
        }
    }
}
