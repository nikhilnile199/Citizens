
using System;

using Citizens.Models ;
using Microsoft.EntityFrameworkCore;




namespace Citizens.Models
{
   public class CitizenContext  : DbContext
    {
    public CitizenContext(DbContextOptions<CitizenContext> options) : base(options)
    {

    }

    public DbSet<CitizenEducationDetails> CitizenEducationDetails { get; set; }
    public DbSet<CitizenMedicalHistory> CitizenMedicalHistory { get; set; }
    public DbSet<CitizenPersonalDetail> CitizenPersonalDetail { get; set; }
    public DbSet<CountryMedicalCenters> CountryMedicalCenters { get; set; }
    public DbSet<CountryMedicalDepartments> CountryMedicalDepartments { get; set; }

}
}


