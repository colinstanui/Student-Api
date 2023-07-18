using Student_Api.Models;
using Student_Api.RegisteredStudentListRef2;
using Student_Api.RegisteredStudentRef2;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Web;

namespace Student_Api.Fuctions
{
    public class Helpers
    {


       

        public static RegisteredStudent GetStudent(string No)

        {

            var student = Webservice.registeredStudent_Service().Read(No);
            return student;
        }
        public static ApplicationUser GetCurrentUser()
        {
            using (var context = new ApplicationDbContext())
            {
                var name = HttpContext.Current.User.Identity.Name;
                var user = context.Users.Where(x => x.UserName == HttpContext.Current.User.Identity.Name).FirstOrDefault();
                return user;
            }



        }

        /*
                var students = Functions.GetStudent(currentUser.StudentNo);*/

        /*public static List<CourseList> GetCourses()
        {
            List<CourseList> courses = new List<CourseList>();
            courses = Webservice.course_service().ReadMultiple(null, null, 0).ToList();

            return courses;
        }*/
        public static List<RegisteredStudentList> GetRegisteredStudents()
        {
            List<RegisteredStudentList> RegisteredStudents = new List<RegisteredStudentList>();
            RegisteredStudents = Webservice.registeredStudentList_Service().ReadMultiple(null, null, 0).ToList();

            return RegisteredStudents;
        }
        /* public static ApplicantForm CreateApplicant(ApplicantForm applicantNo)
         {
             Webservice.applicant_service().Create(ref applicantNo);
             return applicantNo;
         }*/
        public static RegisteredStudent UpdateRegisteredStudents(RegisteredStudent RegisteredStudents)
        {
            Webservice.registeredStudent_Service().Update(ref RegisteredStudents);
            return RegisteredStudents;
        }


        /* public class Webservice
         

             public static CourseList_Service course_service()
             {
                 CourseList_Service service = new CourseList_Service();
                 service.Url = ConfigurationManager.AppSettings["path"] + "Page/CourseList";
                 service.UseDefaultCredentials = false;
                 service.Credentials = credentials;

  *//*               return service;*//*
    }
    public static ApplicantForm_Service applicant_service()
    {
        ApplicantForm_Service service = new ApplicantForm_Service();
        service.Url = ConfigurationManager.AppSettings["path"] + "Page/ApplicantForm";
        service.UseDefaultCredentials = false;
        service.Credentials = credentials;

        return service;
    }


*/
    }

    public class Webservice
    {
        public static RegisteredStudentList_Service registeredStudentList_Service()
        {
            RegisteredStudentList_Service service = new RegisteredStudentList_Service();
            service.Url = ConfigurationManager.AppSettings["path"] + "Page/RegisteredStudentList";
            service.UseDefaultCredentials = false;
            service.Credentials = credentials;

            return service;

        }

        public static RegisteredStudent_Service registeredStudent_Service()

        {
            RegisteredStudent_Service service = new RegisteredStudent_Service();
            service.Url = ConfigurationManager.AppSettings["path"] + "Page/RegisteredStudent";
            service.UseDefaultCredentials = false;
            service.Credentials = credentials;


            return service;
        }

        private static NetworkCredential credentials = new NetworkCredential(ConfigurationManager.AppSettings["SoapUsername"], ConfigurationManager.AppSettings["SoapPassword"]);

    }



}
      





    
