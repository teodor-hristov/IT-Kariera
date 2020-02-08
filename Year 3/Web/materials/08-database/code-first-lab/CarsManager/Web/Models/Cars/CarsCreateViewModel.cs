using System.ComponentModel.DataAnnotations;
using Data.Enumeration;
using Web.Attributes;

namespace Web.Models.Cars
{
    public class CarsCreateViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "BUBA")]
        public string Model { get; set; }

        public int Year { get; set; }

        public EngineEnum Engine { get; set; }
    }
}
