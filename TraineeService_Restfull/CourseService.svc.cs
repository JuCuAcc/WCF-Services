using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using TraineeService_Restfull.Models;

namespace TraineeService_Restfull
{
    public class CourseService : ICourseService
    {
        private TrainingContext context;

        public CourseService()
        {
            context = new TrainingContext();
        }
        public int Add(Course course)
        {
            context.Courses.Add(course);
            int count = context.SaveChanges();
            return count;
        }

        public List<Course> GetCourses()
        {
            List<Course> courses = context.Courses.ToList();
            return courses;
        }
    }
}
