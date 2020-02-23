using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManager_v3.Models
{
    public class ProjectModel
    {
        [Key]
        public String Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public List<TeamModel> Teams { get; set; }
    }
}
