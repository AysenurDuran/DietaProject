using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.Model.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
       
        public string GoalName { get; set; }

        //Navigation Properties
        public ICollection<User> Users { get; set; }
    }
}
