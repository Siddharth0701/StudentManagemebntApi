using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DomainModels;
using WebApi.Repository;

namespace WebApi.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllStudent()
        {
            var students=studentRepository.GetStudents();
            var domainModelStudent = new List<Student>();
            foreach (var student in students)
            {
                domainModelStudent.Add(new Student()
                {
                        Id=student.Id,
                        FirstName=student.FirstName,
                        LastName=student.LastName,
                        DateOfBirth=student.DateOfBirth,
                        Email=student.Email,
                        Mobile=student.Mobile,
                        ProfileImage=student.ProfileImage,
                        GenderId=student.GenderId,
                        Address=new Address()
                        {
                            Id=student.Address.Id,
                            PhysicalAddress=student.Address.PhysicalAddress,
                            PostalAddress=student.Address.PostalAddress,

                        },
                        Gender=new Gender()
                        {
                            Id=student.Gender.Id,
                            Description=student.Gender.Description
                        }

                });
                
            }
            return Ok(domainModelStudent);
        }
    }
}
