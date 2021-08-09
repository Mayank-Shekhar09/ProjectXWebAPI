using ProjectXWebAPIDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectXWebAPIDAL
{
    public class CourseDL
    {
        Course dtCourseObj;
        public CourseDL()
        {
            dtCourseObj = new Course();
        }
        public List<Course> GetCourses()
        {
            try
            {
                List<Course> courseList = new List<Course>();
                WebConStr courseCntx = new WebConStr();
                var dbCourseList = courseCntx.Courses.ToList();
                foreach (var item in dbCourseList)
                {
                    courseList.Add(
                        new Course()
                        {
                            CourseID = item.CourseID,
                            CourseTitle = item.CourseTitle,
                            Duration = item.Duration,
                            Owner = item.Owner,
                            AssessmentMode = item.AssessmentMode
                        });
                }
                return courseList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
