using DeliveryTracker.Data.Interface;
using DeliveryTracker.Data.Models;
using DeliveryTrackingAPI.Data;
using System.Collections.Generic;

namespace DeliveryTracker.Data.Service
{
    public class PackageService : IPackageService
    {
        private IPackageStatusService _PackageStatusService;
        private IStatusService _StatusService;

        public PackageService(IPackageStatusService packageStatusService, IStatusService statusService)
        {
            _PackageStatusService = packageStatusService;
            _StatusService = statusService;
        }

        public List<Package> GetAllPackages()
        {
            return (new PackageData()).GetAllPackages(); // return packages;
        }

        public Package GetPackage(int id)
        {
            return (new PackageData()).GetPackage(id); //return packages.FirstOrDefault(x => x.Id == id);
        }

        public ResponseData CreatePackage(string name)
        {
            return (new PackageData()).CreatePackage(name);
        }

        public ResponseData UpdatePackageStatus(int id, int statusId)
        {
            return (new PackageData()).UpdatePackageStatus(id, statusId);
        }
    }
}
