﻿using System;
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
     
    [Route("[Controller]")]
    [ApiController]
    public class CitizenPersonalController :Controller
    {
        
       private readonly CitizenContext context ;
        

        public CitizenPersonalController(CitizenContext _context)
        {
            context = _context;
        }

        [HttpGet("{AADHARID}")]
        public ActionResult<CitizenPersonalDetail> GetCitizenPersonalDetail(int AADHARID)
        {
            var Items = context.CitizenPersonalDetail.Find(AADHARID);
           if (Items == null)
            {
                return NotFound();
            } 

            return Items;
        }
           [HttpPost]
        public ActionResult<CitizenPersonalDetail> PostCitizenPersonalDetail(CitizenPersonalDetail orderDetail)
        {
            context.CitizenPersonalDetail.Add(orderDetail);

            context.SaveChanges();


            return CreatedAtAction("GetCitizenPersonalDetail",new CitizenPersonalDetail{AADHARID = orderDetail.AADHARID},orderDetail);
        }

             [HttpPut("{AADHARID}")]
        public ActionResult PutCitizenPersonalDetail(int AADHARID, CitizenPersonalDetail student)
        {
            if(AADHARID!= student.AADHARID){
              return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();


            return NoContent();
        }
           [HttpDelete("{AADHARID}")]
        public ActionResult<CitizenPersonalDetail> DeleteCitizenPersonalDetail(int AADHARID)
        {
            var Items = context.CitizenPersonalDetail.Find(AADHARID);
            if (Items == null)
            {
                return NotFound();
            }

            context.CitizenPersonalDetail.Remove(Items);
            context.SaveChanges();
            return Items;
        }


       


      
    }
}

