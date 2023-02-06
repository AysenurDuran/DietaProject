using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.Model.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //navigation Properties
        public ICollection<Food> Foods { get; set; }
    }
}
