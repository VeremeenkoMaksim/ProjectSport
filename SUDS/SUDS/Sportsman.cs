using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SUDS
{
    class Sportsman
    {
        [Key]
        private int SportsmanId { get; set; }
        private string name { get; set; }
        private string surname {get; set;}
        private string middleName { get; set;}
    }
}
