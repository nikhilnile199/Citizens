using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Citizens.Models
{
    public class CitizenMedicalHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CitizenID{get; set;}

        
        [Required]
      public  int MedicalCenterID{get; set;}

         
        [Required]
      public  int MedDeptID{get; set;}
        [Required]
       public string DateOfVisit{get; set;}
        [Required]
       public string CauseOfVisit{get; set;} 
        [Required]
        string Comments{get; set;}
        [Required]
       public string Prescription{get; set;}

       [ForeignKey("MedDeptID")]
         public CountryMedicalDepartments countryMedicalDepartments ;

        [ForeignKey("MedicalCenterID")]
        public CountryMedicalCenters countryMedicalCenters;

    }
}