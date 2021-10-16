using DeliveryTracker.Data.Data;
using DeliveryTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryTrackingAPI.Data
{
    public class PackageStatusData
    {
        public List<PackageStatus> GetAllPackageStatusForPackage(int packageId)
        {
            using PackageDeliveryContext context = new PackageDeliveryContext();

            return context.PackageStatuses.Where(n => n.PackageId == packageId).ToList<PackageStatus>();
        }

        public void CreatePackageStatus(int packageId, int statusId, DateTime time)
        {
            using PackageDeliveryContext context = new PackageDeliveryContext();

            context.PackageStatuses.Add(new PackageStatus { PackageId = packageId, StatusId = statusId, UpdateTime = time });

            context.SaveChanges();
        }
    }
}
