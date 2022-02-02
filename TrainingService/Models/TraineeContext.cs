using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace TrainingService.Models
{
    public class TraineeContext:DbContext
    {
        public TraineeContext():base("DbCon")
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}