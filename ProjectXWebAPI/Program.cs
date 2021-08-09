using ProjectXWebAPIBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //FacultyBL blObj;
                //CourseBL courseObj;
                //GraderBL graderObj;
                //blObj = new FacultyBL();
                //Console.WriteLine("\nFaculty Data");
                //var result = blObj.GetFaculties();
                //foreach (var item in result)
                //{
                //    Console.WriteLine(item.FacultyName + "|" + item.EmailID + "|" + item.PSNo);
                //}
                //courseObj = new CourseBL();
                //Console.WriteLine("\nCourses Data");
                //var result1 = courseObj.GetCourses();
                //foreach (var item in result1)
                //{
                //    Console.WriteLine(item.CourseID + "|" + item.CourseTitle + "|" + item.Duration + "|" + item.Owner + "|" + item.AssessmentMode);
                //}
                //graderObj = new GraderBL();
                //Console.WriteLine("\nGrader Data");
                //var result2 = graderObj.GetGraderDetails();
                //foreach (var item in result2)
                //{
                //    Console.WriteLine(item.Marks_Obtained + "|" + item.Feedback + "|" + item.BatchID + "|" + item.CourseID + "|" + item.ParticipantID);
                //}

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("not found");
                Console.WriteLine(ex);
            }



        }
    }
}
