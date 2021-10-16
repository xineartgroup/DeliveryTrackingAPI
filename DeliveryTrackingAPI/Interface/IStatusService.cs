using DeliveryTracker.Data.Models;
using System.Collections.Generic;

namespace DeliveryTracker.Data.Interface
{
    public interface IStatusService
    {
        public List<Status> GetAllStatus();

        public Status GetStatus(int id);
    }
}
