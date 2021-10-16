using DeliveryTracker.Data.Interface;
using DeliveryTracker.Data.Models;
using DeliveryTrackingAPI.Data;
using System.Collections.Generic;

namespace DeliveryTracker.Data.Service
{
    public class StatusService : IStatusService
    {
        public List<Status> GetAllStatus()
        {
            return (new StatusData()).GetAllStatus(); // return statuses;
        }

        public Status GetStatus(int id)
        {
            return (new StatusData()).GetStatus(id); // return statuses.FirstOrDefault(x => x.Id == id);
        }
    }
}
