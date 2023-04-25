using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstdotnine
{
    internal class Product
    {
        public double Weight { get; set; }
        public double CaloriesPer100g { get; set; }

        public Product(double weight, double caloriesPer100g)
        {
            Weight = weight;
            CaloriesPer100g = caloriesPer100g;
        }

        public double GetAllCalories()
        {
            return Weight / CaloriesPer100g;
        }
    }
}
