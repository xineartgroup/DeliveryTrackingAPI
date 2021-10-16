using System.ComponentModel.DataAnnotations;

namespace DeliveryTracker.Data.Models
{
    public class Status
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "MultiplePerPackage is required")]
        public bool MultiplePerPackage { get; set; }
    }
}
