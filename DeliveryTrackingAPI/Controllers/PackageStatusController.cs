using DeliveryTracker.Data.Interface;
using DeliveryTracker.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DeliveryTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageStatusController : ControllerBase
    {
        private IPackageStatusService _PackageStatusService;

        public PackageStatusController(IPackageStatusService packageStatusService)
        {
            _PackageStatusService = packageStatusService;
        }

        [HttpGet("{id}")]
        public List<PackageStatus> GetAllPackageStatusForPackage(int id)
        {
            return _PackageStatusService.GetAllPackageStatusForPackage(id);
        }
    }
}
