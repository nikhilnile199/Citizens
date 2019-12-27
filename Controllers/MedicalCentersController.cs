//CountryMedicalCenters  MedicalCentersController
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Microsoft.EntityFrameworkCore;
using Citizens.Models ;



namespace Citizens.Controllers
{
     
    [Route("Api/[Controller]")]
    [ApiController]
    public class MedicalCentersController :Controller
    {
        
       private readonly CitizenContext context ;
        

        public MedicalCentersController(CitizenContext _context)
        {
            context = _context;
        }

           [HttpGet("{Id}")]
        public ActionResult<CountryMedicalCenters> GetCountryMedicalCenters(int Id)
        {
            var Items = context.CountryMedicalCenters.Find(Id);
           if (Items == null)
            {
                return NotFound();
            } 

            return Items;
        }
           [HttpPost]
        public ActionResult<CountryMedicalCenters> PostCountryMedicalCenters(CountryMedicalCenters orderDetail)
        {
            context.CountryMedicalCenters.Add(orderDetail);

            context.SaveChanges();


            return CreatedAtAction("GetCountryMedicalCenters",new CountryMedicalCenters{MedicalCenterID = orderDetail.MedicalCenterID},orderDetail);
        }
             [HttpPut("{Id}")]
        public ActionResult PutCountryMedicalCenters(int Id, CountryMedicalCenters student)
        {
            if(Id!= student.MedicalCenterID){
              return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();


            return NoContent();
        }
           [HttpDelete("{Id}")]
        public ActionResult<CountryMedicalCenters> DeleteCountryMedicalCenters(int Id)
        {
            var Items = context.CountryMedicalCenters.Find(Id);
            if (Items == null)
            {
                return NotFound();
            }

            context.CountryMedicalCenters.Remove(Items);
            context.SaveChanges();
            return Items;
        }


       


      
    }
}



