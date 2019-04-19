using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dal;
using Models;

namespace Bll
{
    public class UserInfoBll
    {
        UserInfoDal userinformation = new UserInfoDal();
        public List<UserInfo> GetAllUserInfo()
        {
            return userinformation.GetAllUserInfo();
        }

        public int AddUserInfo(UserInfo f)
        {
            return userinformation.AddUserInfo(f);
        }

        public UserInfo GetUserInfoById(int userid)
        {
            return userinformation.GetUserInfoById(userid);
        }

        public int EditUserInfo(UserInfo f)
        {
            return userinformation.EditUserInfo(f);
        }

        public int DelUserInfo(int userid)
        {
            return userinformation.DelUserInfo(userid);
        }

    }

}