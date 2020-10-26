using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AZIPPYFITNESS.Models
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int locationId{ get; set; }
        public String locationStreetAddress { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public Int32 zipCode { get; set; }
        public String locationShortName { get; set; }
        public String locationphoneNumber { get; set; }
       
    }
}
