
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Citizens.Models
{
    public class CitizenEducationDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CitizenID{get; set; }
        [Required]
        public string EducationBoard{get; set; }
        [Required]
       public string EducationLevel{get; set; }
        [Required]
        public string EducationSpecialization{get; set; }
        [Required]
       public  string YearOfPassing{get; set; }

        [ForeignKey("CitizenID")]
       public CitizenMedicalHistory citizenMedicalHistory;
        


    }
}