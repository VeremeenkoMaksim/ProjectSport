using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SUDS
{
    class KindOfSport
    {
        [Key]
        public int Id { get; set; }
        public string NameOfSport { get; set; }
        public ICollection<string> Category { get; set; }
    }
}
