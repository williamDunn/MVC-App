using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AZIPPYFITNESS.Models
{
    public class MembershipStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int membershipStatusId { get; set; }
        public String membershipStatusDescription { get; set; }
    }
}
