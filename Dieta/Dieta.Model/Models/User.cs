using DataAnnotationsExtensions;
using Dieta.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.Model.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
       
        public string Username { get; set; }
        
        public string Password { get; set; }
       
        public string Email { get; set; }
        public string Fullname { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }
     
        public string Gender { get; set; }
       
        public double Height { get; set; }
       
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public double GoalOfWeight { get; set; }
        public string AboutMe { get; set; }
        [ForeignKey("Goal")]
        public int GoalId { get; set; }
        [ForeignKey("ActivityLevel")]
        public int ActivityLevelId { get; set; }

        public Goal Goal { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        
        public ICollection<DailyProgramme> DailyProgrammes { get; set; }

    }
}
