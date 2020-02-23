using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManager.Models
{

    public class User
    {
        [Key]
        public String Id { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Role { get; set; }
        public Team Team { get; set; }
    }
}
