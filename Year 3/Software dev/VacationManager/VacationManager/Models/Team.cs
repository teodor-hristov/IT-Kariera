using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManager.Models
{
    public class Team
    {
        [Key]
        public String Id { get; set; }
        public String Name { get; set; }
        public Project Project { get; set; }
        public List<User> Developers { get; set; }
        public User TeamLeader { get; set; }
    }
}
