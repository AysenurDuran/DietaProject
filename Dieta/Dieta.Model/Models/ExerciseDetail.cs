using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.Model.Models
{
    public class ExerciseDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("DailyProgramme")]
        public int DailyProgrammeId { get; set; }
        [ForeignKey("Exercise")]
        public int ExerciseId { get; set; }
        
       
        public double Duration { get; set; }

        public DailyProgramme DailyProgramme { get; set; }
        public Exercise Exercise { get; set; }
        
    }
}
