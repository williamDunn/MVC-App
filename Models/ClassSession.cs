using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AZIPPYFITNESS.Models
{
    public class ClassSession
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int classSessionId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int fitnessClassId { get; set; }
        public DateTime classSessionStartTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int locationId { get; set; }
        // NOTE IF WANT TO MAKE IT EASY NEED SAME ATTRIBUTE NAME AS IN LOCATION CLASS !

        public FitnessClass FitnessClass { get; set; }
        public Location Location { get; set; }
    }
}
