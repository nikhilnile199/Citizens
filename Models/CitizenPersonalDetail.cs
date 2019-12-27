
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Citizens.Models
{
    public class CitizenPersonalDetail
    {
        
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [Range(0, 9999999999999999)]
           public int AADHARID{get; set;} 


            [Required]
           public  string FullName{get; set;} 
            [Required]
          public  string DateOfBirth{get; set;}
            [Required] 
          public  string State{get; set;} 
            [Required]
          public  int Pincode{get; set;}
            [Required] 
          public  string Gender{get; set;}
            [Required] 
          public  string EMail{get; set;} 
            [Required]
          public  int PrimaryPhone{get; set;} 
          public  int  OtherPhone{get; set;}
            [Required] 
            public string Address{get; set;} 


    }
}