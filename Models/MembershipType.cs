using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AZIPPYFITNESS.Models
{
    public class MembershipType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int membershipTypeId { get; set; }
        public String membershipTypeDescription { get; set; }
        public double membershipMonthlyRate { get; set; }

    }
}
