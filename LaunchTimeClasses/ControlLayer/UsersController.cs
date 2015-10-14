using LTDataLayer.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.ControlLayer
{
    /// <summary>
    /// Business controller for users
    /// </summary>
    public class UsersController
    {
        /// <summary>
        /// Do login of a user, if it's valid
        /// </summary>
        /// <param name="login">user's login</param>
        /// <returns>the logged user's info</returns>
        public static UserInfo Login(String login)
        {
            UserInfo user = UsersProvider.Instance.Details(new UserInfo() { Login = login });
            if (user != null)
                return user;
            else
                throw new Exception("Invalid login");
        }

        /// <summary>
        /// List all users
        /// </summary>
        /// <returns>a list of users</returns>
        public static List<UserInfo> ListAll()
        {
            return UsersProvider.Instance.SelectAll();
        }
    }
}
