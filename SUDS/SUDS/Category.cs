using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SUDS
{
    public enum Type { weight, age, rank }

    class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Type Type { get; set; }
    }
}
