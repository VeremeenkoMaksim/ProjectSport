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
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

    }
}
