using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaraphonSkills.Core.ModelAPI
{
    public class Review
    {
        public int VolunteerId { get; set; }
        public string lastname { get; set; }
        [Column("firstname")]
        public string firstname { get; set; }
        public string countrycode { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public int reviewId { get; set; }
        public int marathonId { get; set; }
        public int reviewMark { get; set; }
        public string reviewdescription { get; set; }
        public string reviewDateTime { get; set; }
    }
}
