//  CountryMedicalDepartments  MedicalDepartmentsController


//CountryMedicalDepartments   MedicalCentersController
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
    public class MedicalDepartmentsController :Controller
    {
        
       private readonly CitizenContext context ;
        

        public MedicalDepartmentsController(CitizenContext _context)
        {
            context = _context;
        }

           [HttpGet("{Id}")]
        public ActionResult<CountryMedicalDepartments > GetCountryMedicalDepartments (int Id)
        {
            var Items = context.CountryMedicalDepartments .Find(Id);
           if (Items == null)
            {
                return NotFound();
            } 

            return Items;
        }
           [HttpPost]
        public ActionResult<CountryMedicalDepartments > PostCountryMedicalDepartments (CountryMedicalDepartments  orderDetail)
        {
            context.CountryMedicalDepartments .Add(orderDetail);

            context.SaveChanges();


            return CreatedAtAction("GetCountryMedicalDepartments ",new CountryMedicalDepartments {MedicalDeptID= orderDetail.MedicalDeptID},orderDetail);
        }
             [HttpPut("{Id}")]
        public ActionResult PutCountryMedicalDepartments (int Id, CountryMedicalDepartments  student)
        {
            if(Id!= student.MedicalDeptID){
              return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();


            return NoContent();
        }
           [HttpDelete("{Id}")]
        public ActionResult<CountryMedicalDepartments > DeleteCountryMedicalDepartments (int Id)
        {
            var Items = context.CountryMedicalDepartments .Find(Id);
            if (Items == null)
            {
                return NotFound();
            }

            context.CountryMedicalDepartments .Remove(Items);
            context.SaveChanges();
            return Items;
        }


       


      
    }
}



