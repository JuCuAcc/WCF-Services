using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using TrainingService.Models;

namespace TrainingService
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Course> GetCourses();

        [OperationContract]
        Course GetCourseById(int? courseId);


        [OperationContract]
        int Add(Course course);

        [OperationContract]
        int Modify(Course course);

        [OperationContract]
        int Remove(int courseId);

    }  
}
