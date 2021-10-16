using DeliveryTracker.Data.Interface;
using DeliveryTracker.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryTracker.Data.Service
{
    public class StatusService : IStatusService
    {
        private static List<Status> statuses = new List<Status>()
        {
            new Status { Id = 1, Name = "PICKED_UP", MultiplePerPackage = false },
            new Status { Id = 2, Name = "IN_TRANSIT", MultiplePerPackage = true },
            new Status { Id = 3, Name = "WAREHOUSE", MultiplePerPackage = true },
            new Status { Id = 4, Name = "DELIVERED", MultiplePerPackage = false },
        };

        public List<Status> GetAllStatus()
        {
            return statuses;
        }

        public Status GetStatus(int id)
        {
            return statuses.FirstOrDefault(x => x.Id == id);
        }
    }
}
