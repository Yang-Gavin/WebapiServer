using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using Bll;

namespace WebapiServer.Controllers
{
    public class FoodController : ApiController
    {
        FoodBll bll = new FoodBll();
        // GET api/<controller>
        public IEnumerable<Food> GetFood()
        {
            return bll.GetAllFood();
        }

        // GET api/<controller>/5
        public int postFood (Food f)
        {
            return bll.Add(f);
        }

        // POST api/<controller>
        public Food GetFoobById(int id)
        {
            return bll.GetFoodById(id);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public int PutFood(Food f)
        {
            return bll.EditFood(f);
        }

        public int DeleteFood(int id)
        {
            return bll.Del(id);
        }
    }
}