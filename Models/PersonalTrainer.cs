using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AZIPPYFITNESS.Models
{
    public class PersonalTrainer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int trainerId { get; set; }
        public String trainerFirstName { get; set; }
        public String trainerLastName { get; set; }
        public String trainerGender { get; set; }
        public String trainerSpecialties { get; set; }
        public int TrainerPrimaryLocationId { get; set; }
    }
}
