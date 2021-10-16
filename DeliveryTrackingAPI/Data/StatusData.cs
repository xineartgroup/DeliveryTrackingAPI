using DeliveryTracker.Data.Data;
using DeliveryTracker.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryTrackingAPI.Data
{
    public class StatusData
    {
        public List<Status> GetAllStatus()
        {
            using PackageDeliveryContext context = new PackageDeliveryContext();

            return context.Statuses.ToList<Status>();
        }

        public Status GetStatus(int id)
        {
            using PackageDeliveryContext context = new PackageDeliveryContext();

            return context.Statuses.FirstOrDefault(x => x.Id == id);
        }
    }
}
