using DeliveryTracker.Data.Interface;
using DeliveryTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryTracker.Data.Service
{
    public class PackageService : IPackageService
    {
        private static List<Package> packages = new List<Package>()
        {
            new Package { Id = 1, Name = "Mr. Anyanwu's Package" },
            new Package { Id = 2, Name = "Wedding photos for Madam Njide" },
            new Package { Id = 3, Name = "Remi's Stuff..." },
            new Package { Id = 4, Name = "Aunty Temi's wedding cake" }
        };

        private IPackageStatusService _PackageStatusService;
        private IStatusService _StatusService;

        public PackageService(IPackageStatusService packageStatusService, IStatusService statusService)
        {
            _PackageStatusService = packageStatusService;
            _StatusService = statusService;
        }

        public List<Package> GetAllPackages()
        {
            return packages;
        }

        public Package GetPackage(int id)
        {
            return packages.FirstOrDefault(x => x.Id == id);
        }

        public int CreatePackage(string name)
        {
            int id = packages.Count + 1;

            packages.Add(new Package { Id = id, Name = name });

            return id;
        }

        public int UpdatePackageStatus(int id, int statusId)
        {
            Status status = _StatusService.GetStatus(statusId);
            Package package = GetPackage(id);

            if (status == null)
            {
                return 1; //Invalid status id
            }

            if (package == null)
            {
                return 2; //Invalid Package id
            }

            if (!status.MultiplePerPackage)
            {
                List<PackageStatus> pakageStatuses = _PackageStatusService.GetAllPackageStatusForPackage(id);
                List<PackageStatus> list = pakageStatuses.FindAll(dispatch => dispatch.StatusId == statusId);
                if (list.Count > 0)
                {
                    return 3; //Cannot update status to PICKED_UP or DELIVERED 2ce
                }
            }

            _PackageStatusService.CreatePackageStatus(id, statusId, DateTime.Now);

            return 0; //success
        }
    }
}
