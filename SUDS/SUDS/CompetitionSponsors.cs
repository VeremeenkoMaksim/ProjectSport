using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SUDS
{
    class CompetitionSponsors
    {
        [Key]
        public int Id { get; set; }
        public int SponsorId { get; set; }
        [ForeignKey("SponsorId")]
        public User Sponsor { get; set; }

        public int CompetitionId { get; set; }
        [ForeignKey("CompetitionId")]
        public Competition Competition { get; set; }
    }
}
