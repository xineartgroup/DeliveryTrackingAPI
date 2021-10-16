using DeliveryTracker.Data.Interface;
using DeliveryTracker.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DeliveryTrackingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private IStatusService _StatusService;

        public StatusController(IStatusService statusService)
        {
            _StatusService = statusService;
        }

        [HttpGet]
        public ActionResult<List<Status>> GetAllStatuses()
        {
            return _StatusService.GetAllStatus();
        }

        [HttpGet("{id}")]
        public ActionResult<Status> GetStatus(int id)
        {
            Status status = _StatusService.GetStatus(id);

            if (status == null)
                return NotFound();

            return status;
        }
    }
}
