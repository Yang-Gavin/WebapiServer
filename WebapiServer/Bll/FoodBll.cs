using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dal;
using Models;

namespace Bll
{
    public class FoodBll
    {
        FoodDal Dal = new FoodDal();
        public List<Food> GetAllFood()
        {
            return Dal.GetAllFood();
        }

        public int Add(Food f)
        {
            return Dal.Add(f);
        }

        public Food GetFoodById(int id)
        {
            return Dal.GetFoodById(id);
        }

        public int EditFood(Food f)
        {
            return Dal.EditFood(f);
        }

        public int Del(int id)
        {
            return Dal.Del(id);
        }

    }

}