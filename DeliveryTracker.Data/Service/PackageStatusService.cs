using DeliveryTracker.Data.Interface;
using DeliveryTracker.Data.Models;
using System;
using System.Collections.Generic;

namespace DeliveryTracker.Data.Service
{
    public class PackageStatusService : IPackageStatusService
    {
        private static List<PackageStatus> packagestatuses = new List<PackageStatus>()
        {
            new PackageStatus { PackageId = 1, StatusId = 1, UpdateTime = DateTime.Now },
            new PackageStatus { PackageId = 1, StatusId = 2, UpdateTime = DateTime.Now },
            new PackageStatus { PackageId = 1, StatusId = 3, UpdateTime = DateTime.Now },
            new PackageStatus { PackageId = 1, StatusId = 2, UpdateTime = DateTime.Now },
            new PackageStatus { PackageId = 1, StatusId = 3, UpdateTime = DateTime.Now },
            new PackageStatus { PackageId = 1, StatusId = 4, UpdateTime = DateTime.Now },
        };

        public List<PackageStatus> GetAllPackageStatusForPackage(int packageId)
        {
            return packagestatuses.FindAll(n => n.PackageId == packageId);
        }

        public void CreatePackageStatus(int packageId, int statusId, DateTime time)
        {
            packagestatuses.Add(new PackageStatus { PackageId = packageId, StatusId = statusId, UpdateTime = time });
        }
    }
}
