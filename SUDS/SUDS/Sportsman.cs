using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SUDS
{
    class Sportsman : Person
    {
        [Key]
        private int sportsmanId { get; set; }
        private int weight { get; set; }
        private int height { get; set; }

    }
}
