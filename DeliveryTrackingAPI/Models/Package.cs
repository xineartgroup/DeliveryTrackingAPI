using System.ComponentModel.DataAnnotations;

namespace DeliveryTracker.Data.Models
{
    public class Package
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }
    }
}
