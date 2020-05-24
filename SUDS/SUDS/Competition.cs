using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SUDS
{
    public enum CompetitionType {standard, forDisabilties }
    public class Competition
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public KindOfSport KindOfSport { get; set; }
        public ICollection<CompetitionJudges> Judges { get; set; }
        public ICollection<Result> Results { get; set; }
        public ICollection<CompetitionSponsors> Sponsor { get; set; }
    }
}
