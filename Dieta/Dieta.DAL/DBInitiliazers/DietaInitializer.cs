using Dieta.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.DAL.DBInitiliazers
{
    public class DietaInitializer:CreateDatabaseIfNotExists<DietaEntities>
    {
        protected override void Seed(DietaEntities context)
        {
            base.Seed(context);
        }
    }
}
