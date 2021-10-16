using System;
using System.ComponentModel.DataAnnotations;

namespace DeliveryTracker.Data.Models
{
    public class PackageStatus
    {
        [Required(ErrorMessage = "Id is required")]
        public int id { get; set; }

        [Required(ErrorMessage = "PackageId is required")]
        public int PackageId { get; set; }
        
        [Required(ErrorMessage = "StatusId is required")]
        public int StatusId { get; set; }

        [Required(ErrorMessage = "DateTime is required")]
        public DateTime UpdateTime { get; set; }
    }
}
