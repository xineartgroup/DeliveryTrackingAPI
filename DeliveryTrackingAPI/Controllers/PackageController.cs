using DeliveryTracker.Data.Interface;
using DeliveryTracker.Data.Models;
using DeliveryTracker.Data.Service;
using DeliveryTrackingAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DeliveryTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private IPackageService _PackageService;

        public PackageController(IPackageService packageService)
        {
            _PackageService = packageService;
        }

        [HttpGet]
        public ActionResult<List<Package>> GetAllPackages()
        {
            return _PackageService.GetAllPackages();
        }

        [HttpGet("{id}")]
        public ActionResult<Package> GetPackage(int id)
        {
            Package package = _PackageService.GetPackage(id);

            if (package == null)
                return NotFound();

            return package;
        }

        [HttpPost]
        public ActionResult<ResponseData> CreatePackage([FromBody]string name)
        {
            return _PackageService.CreatePackage(name);
        }

        [HttpPut("{id}")]
        public ActionResult<ResponseData> UpdatePackageStatus(int id, [FromBody]int statusId)
        {
            return _PackageService.UpdatePackageStatus(id, statusId);
        }
    }
}
