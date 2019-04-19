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
    public class UserInfoController : ApiController
    {
        UserInfoBll userinformation = new UserInfoBll();
        // GET api/<controller>
        public IEnumerable<UserInfo> GetAllUserInfo()
        {
            return userinformation.GetAllUserInfo();
        }

        // GET api/<controller>/5
        public int AddUserInfo(UserInfo f)
        {
            return userinformation.AddUserInfo(f);
        }

        // POST api/<controller>
        public UserInfo GetUserInfoById(int userid)
        {
            return userinformation.GetUserInfoById(userid);
        }

      
        // DELETE api/<controller>/5
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