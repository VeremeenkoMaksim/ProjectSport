using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUDS
{
    class Result
    {
        private Competition competition { get; set; }
        private ICollection<Sportsman> sportsman { get; set; }
        private int place { get; set; }
        private string category { get; set; }

    }
}
