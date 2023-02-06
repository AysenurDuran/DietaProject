using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.Model.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        
        public string ExerciseName { get; set; }
        
        public double BurnCaloriesPerMinute { get; set; }

        //Navigation Properties
        public ICollection<ExerciseDetail> ExerciseDetails { get; set; }
    }
}
