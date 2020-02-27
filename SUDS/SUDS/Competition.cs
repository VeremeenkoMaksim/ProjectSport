using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SUDS
{
    class Competition
    {
        [Key]
        private int competitionId { get; set; }
        private DateTime date { get; set; }
        private KindOfSport kindOfSport {get; set;}
        private User judge { get; set; }


    }
}
