using Data.Enumeration;
using System.ComponentModel.DataAnnotations;

namespace Web.Models.Cars
{
    public class CarsEditViewModel
    {
       
        public int Id { get; set; }

        [Required]
        [StringLength(50,ErrorMessage = "BUBA")]
        public string Brand { get; set; }

     
        public string Model { get; set; }

        public int Year { get; set; }

        public EngineEnum Engine { get; set; }
    }
}
