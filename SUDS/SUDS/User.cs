using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SUDS
{
    public class User : Person
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public ICollection<CompetitionJudges> JudgedCompetitions { get; set; }

    }
}
