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
    public class CitizenEducationController :Controller
    {
        
       private readonly CitizenContext context ;
        

        public CitizenEducationController(CitizenContext _context)
        {
            context = _context;
        }

           [HttpGet("{CitizenID}")]
        public ActionResult<CitizenEducationDetails> GetCitizenEducationDetails(int CitizenID)
        {
            var Items = context.CitizenEducationDetails.Find(CitizenID);
           if (Items == null)
            {
                return NotFound();
            } 

            return Items;
        }
           [HttpPost]
        public ActionResult<CitizenEducationDetails> PostCitizenEducationDetails(CitizenEducationDetails orderDetail)
        {
            context.CitizenEducationDetails.Add(orderDetail);

            context.SaveChanges();


            return CreatedAtAction("GetCitizenEducationDetails",new CitizenEducationDetails{CitizenID= orderDetail.CitizenID},orderDetail);
        }
             [HttpPut("{CitizenID}")]
        public ActionResult PutCitizenEducationDetails(int CitizenID, CitizenEducationDetails student)
        {
            if(CitizenID!= student.CitizenID){
              return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();


            return NoContent();
        }
           [HttpDelete("{CitizenID}")]
        public ActionResult<CitizenEducationDetails> DeleteCitizenEducationDetails(int CitizenID)
        {
            var Items = context.CitizenEducationDetails.Find(CitizenID);
            if (Items == null)
            {
                return NotFound();
            }

            context.CitizenEducationDetails.Remove(Items);
            context.SaveChanges();
            return Items;
        }


       


      
    }
}



