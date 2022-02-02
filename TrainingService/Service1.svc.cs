using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using TrainingService.Models;
using System.Data.Entity;

namespace TrainingService
{
    public class Service1 : IService1
    {

        private TraineeContext context;
        public Service1()
        {
            context = new TraineeContext();
        }

        public int Add(Course course)
        {
            context.Courses.Add(course);
            int count = context.SaveChanges();
            return count;
        }

        public Course GetCourseById(int? courseId)
        {
            if (courseId != null)
            {
                Course course = context.Courses.Single(c => c.CourseID == courseId);
                return course;
            }
            else
            {
                return null;
            }
        }

        public List<Course> GetCourses()
        {
            List<Course> courses = context.Courses.ToList();
            return courses;
        }

        public int Modify(Course course)
        {
            context.Entry(course).State = EntityState.Modified;
            int count = context.SaveChanges();
            return count;
        }

        public int Remove(int courseId)
        {
            Course course = context.Courses.Find(courseId);
            context.Courses.Remove(course);
            int count = context.SaveChanges();
            return count;
        }
    }
}
