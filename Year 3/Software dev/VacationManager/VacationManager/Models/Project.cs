using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManager.Models
{
    public class Project
    {
        [Key]
        public String Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public List<Team> Teams { get; set; }
    }
}
