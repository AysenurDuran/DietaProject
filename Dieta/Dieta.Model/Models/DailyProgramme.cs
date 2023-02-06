using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.Model.Models
{
    public class DailyProgramme
    {
        [Key]
        public int Id { get; set; }
        
        
        public int Day { get; set; }
       
        public int Month { get; set; }
        
        public int Year { get; set; }
        public double GoalOfCal { get; set; }
        
        public double TotalCal { get; set; }
        
        public double TotalBurnedCal { get; set; }
       
        public double NetCal { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<FoodDetail> FoodDetails { get; set; }
        public ICollection<ExerciseDetail> ExerciseDetails { get; set; }
    }
}
