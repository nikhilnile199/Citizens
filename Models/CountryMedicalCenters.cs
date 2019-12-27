
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Citizens.Models
{
    public class CountryMedicalCenters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
     public int MedicalCenterID{get; set;}
      [DatabaseGenerated(DatabaseGeneratedOption.None)]
     public int StateID{get; set;}
      [Required]
     public string Name {get; set;}
      [Required]
     public string Location{get; set;}

    }
}