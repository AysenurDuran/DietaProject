using Dieta.DAL.Entity;
using Dieta.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Dieta.DAL.DBInitiliazers
{
    public class DietaInitializer : CreateDatabaseIfNotExists<DietaEntities>
    {
        protected override void Seed(DietaEntities context)
        {
            #region AddActivityLevels
            ActivityLevel activityLevel1 = new ActivityLevel() { ActivityLevelName = "Not Active", Description = "*Spend most of the day sitting(e.g. Bank teller,desk job)" };
            ActivityLevel activityLevel2 = new ActivityLevel() { ActivityLevelName = "Ligthly Active", Description = "*Spend a good part of the day  on your feet (e.g. teacher, salesperson)" };
            ActivityLevel activityLevel3 = new ActivityLevel() { ActivityLevelName = "Active", Description = "*Spend a good part of the day doing some pyhsical activity (e.g. food server, postal carrier)" };
            ActivityLevel activityLevel4 = new ActivityLevel() { ActivityLevelName = "Very Active", Description = "*Spend a good part of the day doing heavy physical activity (e.g. bike messenger, carpenter)" };
            context.ActivityLevels.Add(activityLevel1);
            context.ActivityLevels.Add(activityLevel2);
            context.ActivityLevels.Add(activityLevel3);
            context.ActivityLevels.Add(activityLevel4);
            #endregion

            #region AddGoals
            Goal goal1 = new Goal() { GoalName = "Lose Weight" };
            Goal goal2 = new Goal() { GoalName = "Stay Weight" };
            Goal goal3 = new Goal() { GoalName = "Gain Weight" };

            context.Goals.Add(goal1);
            context.Goals.Add(goal2);
            context.Goals.Add(goal3);
            #endregion

            #region AddMeals
            Meal meal1 = new Meal() { MealName = "Breakfast" };
            Meal meal2 = new Meal() { MealName = "Lunch" };
            Meal meal3 = new Meal() { MealName = "Dinner" };
            Meal meal4 = new Meal() { MealName = "Snacks" };

            context.Meals.Add(meal1);
            context.Meals.Add(meal2);
            context.Meals.Add(meal3);
            context.Meals.Add(meal4);
            #endregion

            #region AddCategories
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    CategoryName = "Meals",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "Sea ​​Products",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "Vegetables",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "Fruits",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "​​Meat Products",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "Dairy products",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "Fats",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "Bread Group",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "Nuts",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "Desserts",
                    Description = " "
                },
                new Category()
                {
                    CategoryName = "Beverages",
                    Description = " "
                }
            };
            for (int i = 0; i < categories.Count; i++)
            {
                context.Categories.Add(categories[i]);
            }
            #endregion

            #region AddFoods

            List<Food> foods = new List<Food>()
            {
                new Food()
                {
                    Name = "Raspberry",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 60,
                    Fat = 0,
                    Protein = 3,
                    Sugar = 8,
                    Carbs = 10,
                    Sodium = 50
                },
                new Food()
                {
                    Name = "Pineapple",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 50,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 10,
                    Carbs = 13,
                    Sodium = 1
                },
                new Food()
                {
                    Name = "Blue Berry",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 112,
                    Fat = 4,
                    Protein = 18,
                    Sugar = 0,
                    Carbs = 2,
                    Sodium = 390
                },
                new Food()
                {
                    Name = "Avocado",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 160,
                    Fat = 15,
                    Protein = 2,
                    Sugar = 1,
                    Carbs = 9,
                    Sodium = 7
                },
                new Food()
                {
                    Name = "Apple",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 104,
                    Fat = 0,
                    Protein = 2,
                    Sugar = 21,
                    Carbs = 28,
                    Sodium = 2
                },
                new Food()
                {
                    Name = "Banana",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 105,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 14,
                    Carbs = 27,
                    Sodium = 1
                },
                new Food()
                {
                    Name = "Grape",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 52,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 12,
                    Carbs = 14,
                    Sodium = 2
                },
                new Food()
                {
                    Name = "Pear",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 101,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 17,
                    Carbs = 27,
                    Sodium = 2
                },
                new Food()
                {
                    Name = "Orange",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 62,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 12,
                    Carbs = 15,
                    Sodium = 2
                },
                new Food()
                {
                    Name = "Fig",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 37,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 8,
                    Carbs = 10,
                    Sodium = 1
                },
                new Food()
                {
                    Name = "Plum",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 35,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 7,
                    Carbs = 9,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Cherry",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 5,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 1,
                    Carbs = 1,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Sour cherry",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 150,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 30,
                    Carbs = 38,
                    Sodium = 70
                },
                new Food()
                {
                    Name = "Apricot",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 17,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 3,
                    Carbs = 4,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Tangerine",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 40,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 8,
                    Carbs = 10,
                    Sodium = 2
                },
                new Food()
                {
                    Name = "Peach",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 63,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 13,
                    Carbs = 15,
                    Sodium = 20
                },
                new Food()
                {
                    Name = "Strawberry",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 4,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 1,
                    Carbs = 1,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Melon",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 53,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 12,
                    Carbs = 13,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Lemon",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 17,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 2,
                    Carbs = 5,
                    Sodium = 1
                },
                new Food()
                {
                    Name = "Water Melon",
                    Photo = "",
                    CategoryId = 4,
                    Calories = 86,
                    Fat = 0,
                    Protein = 2,
                    Sugar = 18,
                    Carbs = 21,
                    Sodium = 3
                },
                new Food()
                {
                    Name = "Corn",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 100,
                    Fat = 1,
                    Protein = 3,
                    Sugar = 0,
                    Carbs = 21,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Pea",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 25,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 2,
                    Carbs = 4,
                    Sodium = 5
                },
                new Food()
                {
                    Name = "Boiled Potato",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 144,
                    Fat = 1,
                    Protein = 3,
                    Sugar = 1,
                    Carbs = 33,
                    Sodium = 8
                },
                new Food()
                {
                    Name = "Leek",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 55,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 4,
                    Carbs = 13,
                    Sodium = 18
                },
                new Food()
                {
                    Name = "Beet",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 58,
                    Fat = 0,
                    Protein = 2,
                    Sugar = 0,
                    Carbs = 13,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Carrot",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 25,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 3,
                    Carbs = 6,
                    Sodium = 42
                },
                new Food()
                {
                    Name = "Celery",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 6,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 1,
                    Carbs = 1,
                    Sodium = 32
                },
                new Food()
                {
                    Name = "Onion",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 32,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 3,
                    Carbs = 7,
                    Sodium = 3
                },
                new Food()
                {
                    Name = "Bean",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 100,
                    Fat = 1,
                    Protein = 6,
                    Sugar = 12,
                    Carbs = 17,
                    Sodium = 32
                },
                new Food()
                {
                    Name = "Mushroom",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 21,
                    Fat = 0,
                    Protein = 3,
                    Sugar = 2,
                    Carbs = 3,
                    Sodium = 5
                },
                new Food()
                {
                    Name = "Cauli",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 89,
                    Fat = 2,
                    Protein = 5,
                    Sugar = 5,
                    Carbs = 14,
                    Sodium = 981
                },
                new Food()
                {
                    Name = "Spinach",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 7,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 0,
                    Carbs = 1,
                    Sodium = 24
                },
                new Food()
                {
                    Name = "Cabbage",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 22,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 3,
                    Carbs = 5,
                    Sodium = 16
                },
                new Food()
                {
                    Name = "Paprika",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 20,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 0,
                    Carbs = 3,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Tomato",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 22,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 3,
                    Carbs = 5,
                    Sodium = 6
                },
                new Food()
                {
                    Name = "Radish",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 0,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 1
                },
                new Food()
                {
                    Name = "Cucumber",
                    Photo = "",
                    CategoryId = 3,
                    Calories = 19,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 2,
                    Carbs = 3,
                    Sodium = 3
                },
                new Food()
                {
                    Name = "Baked Bean",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 239,
                    Fat = 1,
                    Protein = 12,
                    Sugar = 20,
                    Carbs = 54,
                    Sodium = 871
                },
                new Food()
                {
                    Name = "Pea with Carrot",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 41,
                    Fat = 0,
                    Protein = 3,
                    Sugar = 0,
                    Carbs = 7,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Hummus",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 272,
                    Fat = 13,
                    Protein = 10,
                    Sugar = 0,
                    Carbs = 26,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Steamed Artichoke",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 60,
                    Fat = 0,
                    Protein = 4,
                    Sugar = 1,
                    Carbs = 13,
                    Sodium = 120
                },
                new Food()
                {
                    Name = "Sultan's Delight",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 476,
                    Fat = 40,
                    Protein = 11,
                    Sugar = 4,
                    Carbs = 22,
                    Sodium = 206
                },
                new Food()
                {
                    Name = "Minced Beef Pide",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 199,
                    Fat = 4,
                    Protein = 13,
                    Sugar = 0,
                    Carbs = 28,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Potato Puree",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 90,
                    Fat = 1,
                    Protein = 2,
                    Sugar = 0,
                    Carbs = 18,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Steamed Celery",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 15,
                    Fat = 0,
                    Protein = 1,
                    Sugar = 0,
                    Carbs = 1,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Potato Salad",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 125,
                    Fat = 18,
                    Protein = 3,
                    Sugar = 0,
                    Carbs = 15,
                    Sodium = 200
                },
                new Food()
                {
                    Name = "Adana Kebab",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 527,
                    Fat = 20,
                    Protein = 27,
                    Sugar = 6,
                    Carbs = 59,
                    Sodium = 818
                },
                new Food()
                {
                    Name = "Bulgur Pilaf",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 132,
                    Fat = 5,
                    Protein = 4,
                    Sugar = 2,
                    Carbs = 20,
                    Sodium = 400
                },
                new Food()
                {
                    Name = "Mixed Pide with Cheese",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 218,
                    Fat = 11,
                    Protein = 12,
                    Sugar = 0,
                    Carbs = 19,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Lasagna",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 131,
                    Fat = 5,
                    Protein = 7,
                    Sugar = 0,
                    Carbs = 13,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Stuffed Grape Leave",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 120,
                    Fat = 6,
                    Protein = 2,
                    Sugar = 1,
                    Carbs = 14,
                    Sodium = 510
                },
                new Food()
                {
                    Name = "Pasta with Cheese",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 400,
                    Fat = 2,
                    Protein = 30,
                    Sugar = 0,
                    Carbs = 114,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Salad with Grilled Chicken",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 200,
                    Fat = 0,
                    Protein = 17,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Stuffed Peppers Minced Meat",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 149,
                    Fat = 9,
                    Protein = 10,
                    Sugar = 0,
                    Carbs = 5,
                    Sodium = 1
                },
                new Food()
                {
                    Name = "Green Runner Bean",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 29,
                    Fat = 0,
                    Protein = 2,
                    Sugar = 3,
                    Carbs = 3,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Eggplant with Minced Meat",
                    Photo = "",
                    CategoryId = 1,
                    Calories = 171,
                    Fat = 16,
                    Protein = 5,
                    Sugar = 0,
                    Carbs = 2,
                    Sodium = 185
                },
                new Food()
                {
                    Name = "Octopus",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 22,
                    Fat = 0,
                    Protein = 5,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 130
                },
                new Food()
                {
                    Name = "Shrimp",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 60,
                    Fat = 1,
                    Protein = 12,
                    Sugar = 0,
                    Carbs = 1,
                    Sodium = 481
                },
                new Food()
                {
                    Name = "Fried Calamaris",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 220,
                    Fat = 9,
                    Protein = 6,
                    Sugar = 0,
                    Carbs = 28,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Stuffed Mussel",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 172,
                    Fat = 5,
                    Protein = 9,
                    Sugar = 1,
                    Carbs = 11,
                    Sodium = 369
                },
                new Food()
                {
                    Name = "Fried Anchovies",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 199,
                    Fat = 12,
                    Protein = 22,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 0

                },
                new Food()
                {
                    Name = "Salmon",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 280,
                    Fat = 15,
                    Protein = 36,
                    Sugar = 0,
                    Carbs = 1,
                    Sodium = 170
                },
                new Food()
                {
                    Name = "Bonito",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 253,
                    Fat = 17,
                    Protein = 25,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 1020
                },
                new Food()
                {
                    Name = "Sea Bass",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 125,
                    Fat = 3,
                    Protein = 24,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 88
                },
                new Food()
                {
                    Name = "Bream",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 120,
                    Fat = 8,
                    Protein = 24,
                    Sugar = 0,
                    Carbs = 4,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Mackerel",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 231,
                    Fat = 16,
                    Protein = 21,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 73
                },
                new Food()
                {
                    Name = "Red Mullet",
                    Photo = "",
                    CategoryId = 2,
                    Calories = 90,
                    Fat = 4,
                    Protein = 14,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 65
                },
                new Food()
                {
                    Name = "Pork",
                    Photo = "",
                    CategoryId = 5,
                    Calories = 140,
                    Fat = 9,
                    Protein = 12,
                    Sugar = 0,
                    Carbs = 1,
                    Sodium = 350
                },
                new Food()
                {
                    Name = "Duck",
                    Photo = "",
                    CategoryId = 5,
                    Calories = 472,
                    Fat = 40,
                    Protein = 27,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 83
                },
                new Food()
                {
                    Name = "Mutton",
                    Photo = "",
                    CategoryId = 5,
                    Calories = 294,
                    Fat = 21,
                    Protein = 25,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 72
                },
                new Food()
                {
                    Name = "Beef",
                    Photo = "",
                    CategoryId = 5,
                    Calories = 170,
                    Fat = 8,
                    Protein = 23,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 75
                },
                new Food()
                {
                    Name = "Lamb Chop",
                    Photo = "",
                    CategoryId = 5,
                    Calories = 160,
                    Fat = 7,
                    Protein = 23,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Chicken Breast",
                    Photo = "",
                    CategoryId = 5,
                    Calories = 211,
                    Fat = 7,
                    Protein = 36,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 424
                },
                new Food()
                {
                    Name = "Turkey Breast",
                    Photo = "",
                    CategoryId = 5,
                    Calories = 189,
                    Fat = 7,
                    Protein = 34,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 63
                },
                new Food()
                {
                    Name = "Steak",
                    Photo = "",
                    CategoryId = 5,
                    Calories = 190,
                    Fat = 10,
                    Protein = 24,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 60
                },
                new Food()
                {
                    Name = "Kashar Cheese",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 353,
                    Fat = 18,
                    Protein = 27,
                    Sugar = 0,
                    Carbs = 3,
                    Sodium = 2
                },
                new Food()
                {
                    Name = "Cream Cheese",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 53,
                    Fat = 5,
                    Protein = 1,
                    Sugar = 1,
                    Carbs = 1,
                    Sodium = 47
                },
                new Food()
                {
                    Name = "String Cheese",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 84,
                    Fat = 6,
                    Protein = 7,
                    Sugar = 1,
                    Carbs = 1,
                    Sodium = 198
                },
                new Food()
                {
                    Name = "White Cheese",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 70,
                    Fat = 5,
                    Protein = 6,
                    Sugar = 1,
                    Carbs = 1,
                    Sodium = 210
                },
                new Food()
                {
                    Name = "Bryndza",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 294,
                    Fat = 23,
                    Protein = 19,
                    Sugar = 0,
                    Carbs = 2,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Sheep Milk",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 110,
                    Fat = 9,
                    Protein = 7,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 480
                },
                new Food()
                {
                    Name = "Curd Cheese",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 110,
                    Fat = 9,
                    Protein = 7,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Yoghurt",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 69,
                    Fat = 4,
                    Protein = 4,
                    Sugar = 5,
                    Carbs = 5,
                    Sodium = 52
                },
                new Food()
                {
                    Name = "Cow Milk",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 130,
                    Fat = 3,
                    Protein = 10,
                    Sugar = 15,
                    Carbs = 16,
                    Sodium = 160
                },
                new Food()
                {
                    Name = "Ayran",
                    Photo = "",
                    CategoryId = 6,
                    Calories = 60,
                    Fat = 3,
                    Protein = 4,
                    Sugar = 0,
                    Carbs = 4,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Sunflower Seed Oil",
                    Photo = "",
                    CategoryId = 7,
                    Calories = 135,
                    Fat = 15,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Olive Oil",
                    Photo = "",
                    CategoryId = 7,
                    Calories = 119,
                    Fat = 14,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Margarine",
                    Photo = "",
                    CategoryId = 7,
                    Calories = 70,
                    Fat = 8,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 110
                },
                new Food()
                {
                    Name = "Butter",
                    Photo = "",
                    CategoryId = 7,
                    Calories = 32,
                    Fat = 4,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 29
                },
                new Food()
                {
                    Name = "Mayonnaise",
                    Photo = "",
                    CategoryId = 7,
                    Calories = 94,
                    Fat = 10,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 88
                },
                new Food()
                {
                    Name = "Mustard",
                    Photo = "",
                    CategoryId = 7,
                    Calories = 3,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 55
                },
                new Food()
                {
                    Name = "Ketchup",
                    Photo = "",
                    CategoryId = 7,
                    Calories = 17,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 4,
                    Carbs = 5,
                    Sodium = 154
                },
                new Food()
                {
                    Name = "Phyllo",
                    Photo = "",
                    CategoryId = 8,
                    Calories = 170,
                    Fat = 3,
                    Protein = 5,
                    Sugar = 2,
                    Carbs = 30,
                    Sodium = 300
                },
                new Food()
                {
                    Name = "White Bread",
                    Photo = "",
                    CategoryId = 8,
                    Calories = 76,
                    Fat = 1,
                    Protein = 3,
                    Sugar = 1,
                    Carbs = 14,
                    Sodium = 134
                },
                new Food()
                {
                    Name = "Rye Bread",
                    Photo = "",
                    CategoryId = 8,
                    Calories = 83,
                    Fat = 1,
                    Protein = 3,
                    Sugar = 1,
                    Carbs = 15,
                    Sodium = 193
                },
                new Food()
                {
                    Name = "Whole Wheat Bread",
                    Photo = "",
                    CategoryId = 8,
                    Calories = 91,
                    Fat = 1,
                    Protein = 4,
                    Sugar = 2,
                    Carbs = 16,
                    Sodium = 162
                },
                new Food()
                {
                    Name = "Walnut",
                    Photo = "",
                    CategoryId = 9,
                    Calories = 654,
                    Fat = 65,
                    Protein = 15,
                    Sugar = 3,
                    Carbs = 14,
                    Sodium = 2
                },
                new Food()
                {
                    Name = "Hazelnut",
                    Photo = "",
                    CategoryId = 9,
                    Calories = 629,
                    Fat = 61,
                    Protein = 15,
                    Sugar = 4,
                    Carbs = 17,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Almond",
                    Photo = "",
                    CategoryId = 9,
                    Calories = 600,
                    Fat = 56,
                    Protein = 24,
                    Sugar = 0,
                    Carbs = 24,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Pistachio",
                    Photo = "",
                    CategoryId = 9,
                    Calories = 189,
                    Fat = 9,
                    Protein = 4,
                    Sugar = 24,
                    Carbs = 25,
                    Sodium = 64
                },
                new Food()
                {
                    Name = "Peanut",
                    Photo = "",
                    CategoryId = 9,
                    Calories = 567,
                    Fat = 49,
                    Protein = 26,
                    Sugar = 5,
                    Carbs = 16,
                    Sodium = 18
                },
                new Food()
                {
                    Name = "Popcorn",
                    Photo = "",
                    CategoryId = 9,
                    Calories = 155,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Chocolate Cake",
                    Photo = "",
                    CategoryId = 10,
                    Calories = 269,
                    Fat = 13,
                    Protein = 4,
                    Sugar = 20,
                    Carbs = 34,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Biscuit",
                    Photo = "",
                    CategoryId = 10,
                    Calories = 154,
                    Fat = 7,
                    Protein = 3,
                    Sugar = 2,
                    Carbs = 20,
                    Sodium = 360
                },
                new Food()
                {
                    Name = "Apple Pie",
                    Photo = "",
                    CategoryId = 10,
                    Calories = 250,
                    Fat = 8,
                    Protein = 3,
                    Sugar = 0,
                    Carbs = 40,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Ice Cream",
                    Photo = "",
                    CategoryId = 10,
                    Calories = 279,
                    Fat = 15,
                    Protein = 5,
                    Sugar = 29,
                    Carbs = 32,
                    Sodium = 108
                },
                new Food()
                {
                    Name = "Milk Chocolate",
                    Photo = "",
                    CategoryId = 10,
                    Calories = 210,
                    Fat = 13,
                    Protein = 3,
                    Sugar = 24,
                    Carbs = 26,
                    Sodium = 35
                },
                new Food()
                {
                    Name = "Bitter Chocolate",
                    Photo = "",
                    CategoryId = 10,
                    Calories = 220,
                    Fat = 13,
                    Protein = 3,
                    Sugar = 5,
                    Carbs = 23,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Baklava",
                    Photo = "",
                    CategoryId = 10,
                    Calories = 334,
                    Fat = 23,
                    Protein = 5,
                    Sugar = 10,
                    Carbs = 29,
                    Sodium = 253
                },
                new Food()
                {
                    Name = "Rice Pudding",
                    Photo = "",
                    CategoryId = 10,
                    Calories = 196,
                    Fat = 2,
                    Protein = 6,
                    Sugar = 14,
                    Carbs = 21,
                    Sodium = 125
                },
                new Food()
                {
                    Name = "Coke",
                    Photo = "",
                    CategoryId = 11,
                    Calories = 44,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 11,
                    Carbs = 11,
                    Sodium = 2
                },
                new Food()
                {
                    Name = "Apple Juice",
                    Photo = "",
                    CategoryId = 11,
                    Calories = 42,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 10,
                    Carbs = 10,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Orange Juice",
                    Photo = "",
                    CategoryId = 11,
                    Calories = 112,
                    Fat = 0,
                    Protein = 2,
                    Sugar = 10,
                    Carbs = 26,
                    Sodium = 3
                },
                new Food()
                {
                    Name = "Ice Tea",
                    Photo = "",
                    CategoryId = 11,
                    Calories = 30,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 7,
                    Carbs = 7,
                    Sodium = 0
                },
                new Food()
                {
                    Name = "Coffee",
                    Photo = "",
                    CategoryId = 11,
                    Calories = 1,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 5
                },
                new Food()
                {
                    Name = "Tea",
                    Photo = "",
                    CategoryId = 11,
                    Calories = 1,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 1,
                    Sodium = 7
                },
                new Food()
                {
                    Name = "Green Tea",
                    Photo = "",
                    CategoryId = 11,
                    Calories = 0,
                    Fat = 0,
                    Protein = 0,
                    Sugar = 0,
                    Carbs = 0,
                    Sodium = 16
                }
            };

            for (int i = 0; i < foods.Count; i++)
            {
                context.Foods.Add(foods[i]);
            }
            #endregion

            #region AddExercise
            List<Exercise> exercises = new List<Exercise>()
            {
                 new Exercise()
            {
                ExerciseName = "Walking (Medium Pace)",
                BurnCaloriesPerMinute = 3.3
            },
                 new Exercise()
            {
                ExerciseName = "Gymnastics (Light, E.g. Home Exercise)",
                BurnCaloriesPerMinute = 3.48
            },
                 new Exercise()
            {
                ExerciseName = "Swimming",
                BurnCaloriesPerMinute = 3.98
            },
                 new Exercise()
            {
                ExerciseName = "Cycling",
                BurnCaloriesPerMinute =3.98
            },
                 new Exercise()
            {
                ExerciseName = "Golf (on foot)",
                BurnCaloriesPerMinute =3.98
            },
                 new Exercise()
            {
                ExerciseName = "Table Tennis",
                BurnCaloriesPerMinute =3.98
            },
                 new Exercise()
            {
                ExerciseName = "Dance (Slow Step)",
                BurnCaloriesPerMinute =3.98
            },
                 new Exercise()
            {
                ExerciseName = "Volleyball",
                BurnCaloriesPerMinute =3.98
            },
                 new Exercise()
            {
                ExerciseName = "Motor Ride",
                BurnCaloriesPerMinute =3.98
            },
                  new Exercise()
            {
                ExerciseName = "Bovling",
                BurnCaloriesPerMinute =3.98
            },
                   new Exercise()
            {
                ExerciseName = "Horse riding",
                BurnCaloriesPerMinute =3.98
            },
                   new Exercise()
            {
                ExerciseName = "Hunting",
                BurnCaloriesPerMinute =4.98
            },
                   new Exercise()
            {
                ExerciseName = "Gym Exercises",
                BurnCaloriesPerMinute =5.48
            },
                   new Exercise()
            {
                ExerciseName = "Walk",
                BurnCaloriesPerMinute =5.98
            },
                   new Exercise()
            {
                ExerciseName = "Weight Training (Intermediate)",
                BurnCaloriesPerMinute =5.98
            },
                   new Exercise()
            {
                ExerciseName = "Basketball",
                BurnCaloriesPerMinute =5.98
            },
                   new Exercise()
            {
                ExerciseName = "Circular Operation",
                BurnCaloriesPerMinute =5.98
            },
                new Exercise()
            {
                ExerciseName = "Circular Operation",
                BurnCaloriesPerMinute =5.98
            },
                new Exercise()
            {
                ExerciseName = "Tree Climbing",
                BurnCaloriesPerMinute =5.98
            },
                new Exercise()
            {
                ExerciseName = "Aerobic",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Insanity",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Judo",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Karate",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Cardio",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Kick box",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Leslie",
                BurnCaloriesPerMinute = 6.98
            },
                new Exercise()
            {
                ExerciseName = "Stair Climbing",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Zumba",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Fitness (Exercise)",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Bale",
                BurnCaloriesPerMinute =6.98
            },
                new Exercise()
            {
                ExerciseName = "Football",
                BurnCaloriesPerMinute = 7.98
            },
                new Exercise()
            {
                ExerciseName = "Squat",
                BurnCaloriesPerMinute = 7.98
            },
                new Exercise()
            {
                ExerciseName = "Tennis",
                BurnCaloriesPerMinute = 7.98
            },
                new Exercise()
            {
                ExerciseName = "Rowing Sport",
                BurnCaloriesPerMinute = 7.98
            },
                new Exercise()
            {
                ExerciseName = "Skipping rope",
                BurnCaloriesPerMinute = 9.96
            },
                new Exercise()
            {
                ExerciseName = "Running - 11/kph",
                BurnCaloriesPerMinute = 11.46
            },
                new Exercise()
            {
                ExerciseName = "Hatha Yoga",
                BurnCaloriesPerMinute = 3.8
            },
                new Exercise()
            {
                ExerciseName = "A Light Walk",
                BurnCaloriesPerMinute = 4.25
            },
                new Exercise()
            {
                ExerciseName = "Bowling",
                BurnCaloriesPerMinute = 4.55
            },
                new Exercise()
            {
                ExerciseName = "Ballroom Dancing",
                BurnCaloriesPerMinute = 4.55
            },
                new Exercise()
            {
                ExerciseName = "Tai Chi",
                BurnCaloriesPerMinute = 4.55
            },
                new Exercise()
            {
                ExerciseName = "Canoe",
                BurnCaloriesPerMinute = 5.32
            },
                new Exercise()
            {
                ExerciseName = "A Light Bike Ride",
                BurnCaloriesPerMinute = 6
            },
                new Exercise()
            {
                ExerciseName = "Volleyball",
                BurnCaloriesPerMinute = 6
            },
                new Exercise()
            {
                ExerciseName = " Power Yoga (Athletic Yoga)",
                BurnCaloriesPerMinute = 6
            },
                new Exercise()
            {
                ExerciseName = "   Golf (carrying your clubs)",
                BurnCaloriesPerMinute = 6.5
            },
                 new Exercise()
            {
                ExerciseName = "Ski (Descent)",
                BurnCaloriesPerMinute = 6.5
            },
                 new Exercise()
            {
                ExerciseName = "   Brisk walking",
                BurnCaloriesPerMinute = 6.5
            },
                  new Exercise()
            {
                ExerciseName = "Low Impact Aerobics ",
                BurnCaloriesPerMinute = 7.6
            },
                  new Exercise()
            {
                ExerciseName = "Elliptical bike",
                BurnCaloriesPerMinute = 7.6
            },
                  new Exercise()
            {
                ExerciseName = " Baseball / Softball ",
                BurnCaloriesPerMinute = 7.6
            },
                  new Exercise()
            {
                ExerciseName = " Resistance training / weight lifting",
                BurnCaloriesPerMinute = 7.6
            },
                  new Exercise()
            {
                ExerciseName = "Aerobic Exercises in Water",
                BurnCaloriesPerMinute = 8.3
            },
                  new Exercise()
            {
                ExerciseName = "Light or moderate swimming",
                BurnCaloriesPerMinute = 8.8
            },
                  new Exercise()
            {
                ExerciseName = "Hiking",
                BurnCaloriesPerMinute = 9.1
            },
                  new Exercise()
            {
                ExerciseName = "Rowing exerciser",
                BurnCaloriesPerMinute = 9.1
            },
                  new Exercise()
            {
                ExerciseName = "Water skiing ",
                BurnCaloriesPerMinute = 9.1
            },
                  new Exercise()
            {
                ExerciseName = "Cross-country skiing",
                BurnCaloriesPerMinute = 10.3
            },
                  new Exercise()
            {
                ExerciseName = "Hiking with a backpack",
                BurnCaloriesPerMinute = 10.6
            },
                  new Exercise()
            {
                ExerciseName = "Ice skating",
                BurnCaloriesPerMinute = 10.6
            },
                   new Exercise()
            {
                ExerciseName = "Racquetball",
                BurnCaloriesPerMinute = 10.6
            },
                   new Exercise()
            {
                ExerciseName = "High-impact aerobics ",
                BurnCaloriesPerMinute = 11
            },
                   new Exercise()
            {
                ExerciseName = "Skating",
                BurnCaloriesPerMinute = 11.3
            },
                   new Exercise()
            {
                ExerciseName = "Flag Football ",
                BurnCaloriesPerMinute = 12.1
            },
                   new Exercise()
            {
                ExerciseName = "Tennis (singles)",
                BurnCaloriesPerMinute = 12.1
            },
                   new Exercise()
            {
                ExerciseName = "Running (8 km/h)",
                BurnCaloriesPerMinute = 12.5
            },
                   new Exercise()
            {
                ExerciseName = "Taekwondo",
                BurnCaloriesPerMinute = 15.6
            }
            };

            for (int i = 0; i < exercises.Count; i++)
            {
                context.Exercises.Add(exercises[i]);
            }

            #endregion

            context.SaveChanges();
        }
    }
}
