using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SUDS
{
    public class CompetitionJudges
    {
        [Key]
        public int Id { get; set; }
        public int JudgeId { get; set; }
        [ForeignKey("JudgeId")]
        public User Judge { get; set; }

        public int CompetitionId { get; set; }
        [ForeignKey("CompetitionId")]
        public Competition Competition { get; set; }
    }
}
