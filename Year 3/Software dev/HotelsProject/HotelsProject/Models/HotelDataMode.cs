using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsProject.Models
{
    public class HotelDataMode
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public int Floors { get; set; }
        public int Rooms { get; set; }
    }
}
