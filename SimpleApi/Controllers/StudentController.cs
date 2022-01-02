using SimpleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleApi.Controllers
{
    public class StudentController : ApiController
    {
        List<student> studentData = new List<student>()
        {
            new student(){Id = 1, Name ="Nikita", City="Vadodara"},
            new student(){Id = 2, Name ="Harshita", City ="Surat"},
            new student(){Id = 3, Name ="Shubham", City="Valsad"},
            new student(){Id = 4, Name ="Prashant", City="Ahmedabad"}
        };

        //Get full list
        public IHttpActionResult GetList()
        {
            return Ok(studentData);
        }

        //Get data by id
        public IHttpActionResult GetId(int id)
        {
            var student = studentData.Where(i=>i.Id == id).FirstOrDefault();
            return Ok(student);
        }

        //Get data by name
        [HttpGet]
        public IHttpActionResult getName(string Name)
        {
            var student1 = studentData.Where(x=>x.Name == Name).FirstOrDefault();
            return Ok(student1);
        }

        //Add new record
        [HttpGet]
        public IHttpActionResult AddData(int Id,string Name,string City)
        {
            studentData.Add(new student() { Id = Id, Name = Name, City = City });
            return Ok(studentData);
        }


        //Delete record by id
        [HttpGet]
        public IHttpActionResult Deleteid(int id)
        {
            var student2 = studentData.Where(a=>a.Id == id).FirstOrDefault();
            studentData.Remove(student2);
            return Ok(studentData);
        }

        //adding new record using post method
        [HttpPost]
        public IHttpActionResult PostData(student stud)
        {
            studentData.Add(new student()
            {
                Id = stud.Id,
                Name = stud.Name,
                City = stud.City,
            });
            return Ok(studentData);

        }


        
    }

}
