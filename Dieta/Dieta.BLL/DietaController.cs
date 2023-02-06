using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Dieta.BLL
{
    public static class DietaController
    {
        public static Regex regex { get; set; }
        public enum Gender
        {
            Male, Famale
        }
        public static double CalculateBMR(int gender, double weight, double height, int age, int activityStatus,int goalStatus)
        {
            //Mifflin-St Jeor Equation:
            //BMR = 10W + 6.25H - 5A + 5 -->For men
            //BMR = 10W + 6.25H - 5A - 161 -->For women

            //Katch-McArdle Formula:
            //BMR = 370 + 21.6(1 - F)W -->For all (F: is body fat in percentage)

            //Revised Harris-Benedict Equation
            //BMR = 13.397W + 4.799H - 5.677A + 88.362 -->For men
            //BMR = 9.247W + 3.098H - 4.330A + 447.593  -->For women

            double result = 0;
            if (gender == 0)
            {
                //For men
                result = (13.397 * weight) + (4.799 * height) - (5.677 * age) + 88.362;
            }
            else
            {
                //For women
                result = (9.247 * weight) + (3.098 * height) - (4.330 * age) + 447.593;
            }
            if (goalStatus==1)
            {
                result -= 3700 / 7;
            }
            if (goalStatus==3)
            {
                result += 3700 / 7;
            }

            //Activity statuse göre dönüş değeri değişecek.
            switch (activityStatus)
            {
                case 1:
                    result = result * 1.2;
                    break;
                case 2:
                    result = result * 1.3;
                    break;
                case 3:
                    result = result * 1.4;
                    break;
                case 4:
                    result = result * 1.5;
                    break;
                default:
                    result = result * 1.2;
                    break;
            }
            return result;
        }
        public static double CalculateBMI(int gender, double weight, double height)
        {
            return weight / Math.Pow((height / 100), 2);
        }
        public static double CalculateMealCalories(List<double> foodCalories)
        {
            double result = 0;
            foreach (double foodCalory in foodCalories)
            {
                result += foodCalory;
            }
            return result;
        }
        public static double CalculateExerciseCalories(List<double> exerciseCalories)
        {
            double result = 0;
            foreach (double exercise in exerciseCalories)
            {
                result += exercise;
            }
            return result;
        }
        public static double CalculateNetCalories(double mealCalories, double bmrCalories, double exerciseCalories)
        {
            return mealCalories - bmrCalories - exerciseCalories;
        }
        public static double CalculateLoseWeight(double netCalories)
        {
            //Burn 7400 kcal for lose weight 1 kg
            return netCalories / 7400;
        }
        public static string PasswordHash(string password)
        {
            //Password hashing method can be change but now it's useful.
            SHA256 hash = SHA256.Create();
            password = string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(c => c.ToString()));
            return password;
        }
        public static bool CheckPasswordRules(string password)
        {
            //Regex rules can be change.
            bool passwordRules;
            regex = new Regex("^(?=.*[A-Z]{1,})(?=.*[!:*$&+/,%:;=?@#|]{1,})(?=.*[0-9])(?=.*[a-z]{1,})[A-Za-z$&+/,%:;=?@#|!:0-9]{8,}$");
            if (regex.IsMatch(password))
            {
                passwordRules = true;
            }
            else
            {
                passwordRules = false;
            }
            return passwordRules;
        }
        public static bool CheckEmailRules(string email)
        {
            bool emailRules;
            regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(email))
            {
                emailRules = true;
            }
            else
            {
                emailRules = false;
            }
            return emailRules;
        }
        public static int CalculateAge(DateTime dateTime)
        {
            return Convert.ToInt32(((DateTime.Today - dateTime.Date).TotalDays) / 365);
        }

    }
    
}
