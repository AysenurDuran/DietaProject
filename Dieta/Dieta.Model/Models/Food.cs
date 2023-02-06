using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.Model.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
      
        public byte[] Photo { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public double Sugar { get; set; }
        public double Carbs { get; set; }
        public double Sodium { get; set; }
        //Navigation Properties
        public Category Category { get; set; }
        public ICollection<FoodDetail> FoodDetails { get; set; }

    }
    
}
