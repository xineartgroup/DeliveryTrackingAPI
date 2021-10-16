using DeliveryTracker.Data.Interface;
using DeliveryTracker.Data.Models;
using DeliveryTrackingAPI.Data;
using System;
using System.Collections.Generic;

namespace DeliveryTracker.Data.Service
{
    public class PackageStatusService : IPackageStatusService
    {
        public List<PackageStatus> GetAllPackageStatusForPackage(int packageId)
        {
            return (new PackageStatusData()).GetAllPackageStatusForPackage(packageId); // return packagestatuses.FindAll(n => n.PackageId == packageId);
        }

        public void CreatePackageStatus(int packageId, int statusId, DateTime time)
        {
            (new PackageStatusData()).CreatePackageStatus(packageId, statusId, time); // packagestatuses.Add(new PackageStatus { PackageId = packageId, StatusId = statusId, UpdateTime = time });
        }
    }
}
