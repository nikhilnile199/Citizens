using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Citizens.Models
{
    public class CountryMedicalDepartments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MedicalDeptID{get; set;}
        [Required]
      public  string DepatmentName{get; set;}
      public  string Description{get; set;}
      public  string Comment{get; set;}
    }
}