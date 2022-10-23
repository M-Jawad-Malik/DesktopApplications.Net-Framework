using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentMVC.Models
{
    public class StudentBusinessLayer
    {
        public Student GetById(int studentID,String name)
        {
                Student student = new Student()
                {
                    StudentID = studentID,
                     Name = name,
                     Gender="Male",
                     Branch="SE",
                     Section="D"
                
                };

            return student;
        }
    }
}