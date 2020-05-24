using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SUDS
{
    public class Result
    {
        public int Id { get; set; }
        public int CompetitionId { get; set; }
        [ForeignKey("CompetitionId")]
        public Competition Competition { get; set; }
        public Sportsman Sportsman { get; set; }
        public int Place { get; set; }
        public string Category { get; set; }

    }
}
