using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.ServiceModel.Web;
using TraineeService_Restfull.Models;

namespace TraineeService_Restfull
{
    [ServiceContract]
    public interface ICourseService
    {
        [OperationContract]
        [WebInvoke(UriTemplate= "/GetCourses", Method ="GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Course> GetCourses();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddCourse", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int Add(Course course);
    }
}
