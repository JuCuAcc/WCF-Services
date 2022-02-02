using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingService.Models
{
    [DataContract]
    [Table("Course")]
    public class Course
    {
        [DataMember]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }

        [DataMember]
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [DataMember]
        [Required, DataType(DataType.Currency), Column(TypeName ="MONEY")]
        public decimal Price { get; set; }
    }
}