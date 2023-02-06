using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.Model.Models
{
    public class Meal
    {

        [Key]
        public int Id { get; set; }
       
        public string MealName { get; set; }
        
        public ICollection<FoodDetail> FoodDetails { get; set; }

    }
}
