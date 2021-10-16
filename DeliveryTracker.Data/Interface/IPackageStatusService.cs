using DeliveryTracker.Data.Models;
using System;
using System.Collections.Generic;

namespace DeliveryTracker.Data.Interface
{
    public interface IPackageStatusService
    {
        public List<PackageStatus> GetAllPackageStatusForPackage(int packageId);

        public void CreatePackageStatus(int packageId, int statusId, DateTime time);
    }
}
