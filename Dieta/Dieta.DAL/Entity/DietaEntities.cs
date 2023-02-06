using Dieta.DAL.DBInitiliazers;
using Dieta.Model.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace Dieta.DAL.Entity
{
    public class DietaEntities : DbContext
    {
        // Your context has been configured to use a 'DietaEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Dieta.DAL.Entity.DietaEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DietaEntities' 
        // connection string in the application configuration file.
        public DietaEntities()
            : base("name=DietaEntities")
        {
            Database.SetInitializer(new DietaInitializer());
            Database.Initialize(false);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<ActivityLevel> ActivityLevels { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<DailyProgramme> DailyProgrammes { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ExerciseDetail> ExerciseDetails { get; set; }
        public virtual DbSet<FoodDetail> FoodDetails { get; set; }
        
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}