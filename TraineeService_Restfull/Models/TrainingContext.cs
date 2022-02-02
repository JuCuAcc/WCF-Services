using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

using System.Data.Entity;

namespace TraineeService_Restfull.Models
{
    public class TrainingContext:DbContext
    {
        public TrainingContext():base("DbCon")
        {

        }

        public DbSet<Course> Courses  { get; set; }
    }
}