using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace Dal
{
    public class UserInfoDal
    {
        UserLoginEntity entity = new UserLoginEntity();

        public List<UserInfo> GetAllUserInfo()
        {
            return entity.Userinformation.ToList();
        }

        public int AddUserInfo(UserInfo f)
        {
            entity.Userinformation.Add(f);
            return entity.SaveChanges();
        }

        public UserInfo GetUserInfoById(int id)
        {
            return entity.Userinformation.Find(id);
        }

        public int EditUserInfo(UserInfo f)
        {
            entity.Entry(f).State = System.Data.EntityState.Modified;
            return entity.SaveChanges();
        }

        public int DelUserInfo(int id)
        {
            UserInfo f = entity.Userinformation.Find(id);
            entity.Userinformation.Remove(f);
            return entity.SaveChanges();
        }
    }
}