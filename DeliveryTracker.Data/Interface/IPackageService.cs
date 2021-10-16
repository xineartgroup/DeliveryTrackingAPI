using DeliveryTracker.Data.Models;
using System.Collections.Generic;

namespace DeliveryTracker.Data.Interface
{
    public interface IPackageService
    {
        public List<Package> GetAllPackages();

        public Package GetPackage(int id);

        public int CreatePackage(string name);

        public int UpdatePackageStatus(int id, int statusId);

    }
}
