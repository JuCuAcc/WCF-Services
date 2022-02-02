using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace TraineeService_Restfull.Models
{
    [DataContract]
    [Table("Course")]
    public class Course
    {
        [DataMember]
        public int CourseId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Price { get; set; }
    }
}