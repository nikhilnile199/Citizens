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
    public class CitizenHistoryController :Controller
    {
        
       private readonly CitizenContext context ;
        

        public CitizenHistoryController(CitizenContext _context)
        {
            context = _context;
        }

           [HttpGet("{CitizenID}")]
        public ActionResult<CitizenMedicalHistory> GetCitizenMedicalHistory(int CitizenID)
        {
            var Items = context.CitizenMedicalHistory.Find(CitizenID);
           if (Items == null)
            {
                return NotFound();
            } 

            return Items;
        }
           [HttpPost]
        public ActionResult<CitizenMedicalHistory> PostCitizenMedicalHistory(CitizenMedicalHistory orderDetail)
        {
            context.CitizenMedicalHistory.Add(orderDetail);

            context.SaveChanges();


            return CreatedAtAction("GetCitizenMedicalHistory",new CitizenMedicalHistory{CitizenID= orderDetail.CitizenID},orderDetail);
        }
             [HttpPut("{CitizenID}")]
        public ActionResult PutCitizenMedicalHistory(int CitizenID, CitizenMedicalHistory student)
        {
            if(CitizenID!= student.CitizenID){
              return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();


            return NoContent();
        }
           [HttpDelete("{CitizenID}")]
        public ActionResult<CitizenMedicalHistory> DeleteOrderDetail(int CitizenID)
        {
            var Items = context.CitizenMedicalHistory.Find(CitizenID);
            if (Items == null)
            {
                return NotFound();
            }

            context.CitizenMedicalHistory.Remove(Items);
            context.SaveChanges();
            return Items;
        }


       


      
    }
}



