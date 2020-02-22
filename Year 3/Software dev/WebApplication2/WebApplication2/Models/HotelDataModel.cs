using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class HotelDataModel
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int Stars { get; set; }
        public int Floors { get; set; }
        public int Rooms { get; set; }
    }
}
