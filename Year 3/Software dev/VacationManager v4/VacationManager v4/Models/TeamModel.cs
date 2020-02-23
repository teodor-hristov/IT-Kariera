using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManager_v4.Models
{
    public class TeamModel
    {
        [Key]
        public String Id { get; set; }
        public String Name { get; set; }
        public ProjectModel Project { get; set; }
        public List<UserModel> Developers { get; set; }
        public UserModel TeamLeader { get; set; }
    }
}
