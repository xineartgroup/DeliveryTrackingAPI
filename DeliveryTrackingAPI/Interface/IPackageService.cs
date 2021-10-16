using DeliveryTracker.Data.Models;
using DeliveryTrackingAPI.Data;
using System.Collections.Generic;

namespace DeliveryTracker.Data.Interface
{
    public interface IPackageService
    {
        public List<Package> GetAllPackages();

        public Package GetPackage(int id);

        public ResponseData CreatePackage(string name);

        public ResponseData UpdatePackageStatus(int id, int statusId);

    }
}
