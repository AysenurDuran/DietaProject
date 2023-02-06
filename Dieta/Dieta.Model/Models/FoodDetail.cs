using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.Model.Models
{
    public class FoodDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("DailyProgramme")]
        public int DailyProgrammeId { get; set; }
        [ForeignKey("Food")]
        public int FoodId { get; set; }
        [ForeignKey("Meal")]
        public int MealId { get; set; }
        
        public double Portion { get; set; }
        public DailyProgramme DailyProgramme { get; set; }

        public Food Food { get; set; }
        public Meal Meal { get; set; }


    }
}
