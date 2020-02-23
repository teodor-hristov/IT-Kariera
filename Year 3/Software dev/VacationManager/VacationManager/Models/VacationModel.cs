using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VacationManager.Models
{
    /**
    •	дата - от
    •	дата – до
    •	дата създаване на заявката
    •	половин ден отпуск (вярно или невярно)
    •	одобрена (вярно или невярно)
    •	заявител
     */
    public class VacationModel
    {
        [Key]
        public String Id { get; set; }
        public DateTime VacationFrom { get; set; }
        public DateTime VacationTo { get; set; }
        public DateTime TimeStamp { get; set; }
        public Boolean HalfDayVacation { get; set; }
        public Boolean Agreed { get; set; }
        public UserModel Declarator { get; set; }
    }
}
