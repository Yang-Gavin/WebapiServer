using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace Dal
{
    public class FoodDal
    {
        UserLoginEntity entity = new UserLoginEntity();

        public List<Food> GetAllFood()
        {
            return entity.Foods.ToList();
        }

        public int Add(Food f)
        {
            entity.Foods.Add(f);
            return entity.SaveChanges();
        }

        public Food GetFoodById(int id)
        {
            return entity.Foods.Find(id);
        }

        public int EditFood(Food f)
        {
            entity.Entry(f).State = System.Data.EntityState.Modified;
            return entity.SaveChanges();
        }

        public int Del(int id)
        {
            Food f = entity.Foods.Find(id);
            entity.Foods.Remove(f);
            return entity.SaveChanges();
        }
    }
}