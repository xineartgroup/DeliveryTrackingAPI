using DeliveryTracker.Data.Data;
using DeliveryTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryTrackingAPI.Data
{
    public class PackageData
    {
        public List<Package> GetAllPackages()
        {
            using PackageDeliveryContext context = new PackageDeliveryContext();

            return context.Packages.ToList<Package>();
        }

        public Package GetPackage(int id)
        {
            using PackageDeliveryContext context = new PackageDeliveryContext();

            return context.Packages.FirstOrDefault(x => x.Id == id);
        }

        public ResponseData CreatePackage(string name)
        {
            using PackageDeliveryContext context = new PackageDeliveryContext();

            Package package = new Package { Name = name };

            context.Packages.Add(package);

            context.SaveChanges();

            return new ResponseData("00", "Success!!!");
        }

        public ResponseData UpdatePackageStatus(int id, int statusId)
        {
            Status status = (new StatusData()).GetStatus(statusId);
            Package package = GetPackage(id);

            if (status == null)
            {
                return new ResponseData("01", string.Format("Invalid Status"));
            }

            if (package == null)
            {
                return new ResponseData("02", string.Format("Invalid Package"));
            }

            if (!status.MultiplePerPackage)
            {
                List<PackageStatus> pakageStatuses = (new PackageStatusData()).GetAllPackageStatusForPackage(id);
                List<PackageStatus> list = pakageStatuses.FindAll(dispatch => dispatch.StatusId == statusId);
                if (list.Count > 0)
                {
                    return new ResponseData("03", string.Format("Cannot update status to {0} 2ce", status.Name));
                }
            }

            (new PackageStatusData()).CreatePackageStatus(id, statusId, DateTime.Now);

            return new ResponseData("00", "Success!!!");
        }
    }
}
