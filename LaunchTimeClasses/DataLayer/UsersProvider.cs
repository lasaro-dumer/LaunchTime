using LTDataLayer.ControlLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.DataLayer
{
    /// <summary>
    /// Singleton provider for users
    /// </summary>
    public class UsersProvider : BasicProvider<UserInfo>
    {
        private static UsersProvider instance = null;
        private List<UserInfo> list = null;

        /// <summary>
        /// Private constructor
        /// </summary>
        private UsersProvider()
        {
            if (list == null)
            {
                list = new List<UserInfo>();
                list.Add(new UserInfo() { ID = NextID(), Name = "John", Login = "john" });
                list.Add(new UserInfo() { ID = NextID(), Name = "Jack", Login = "jack" });
                list.Add(new UserInfo() { ID = NextID(), Name = "Zack", Login = "zack" });
                list.Add(new UserInfo() { ID = NextID(), Name = "Mack", Login = "mack" });
            }
        }

        /// <summary>
        /// Gets singleton's instance
        /// </summary>
        public static UsersProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new UsersProvider();
                return instance;
            }
        }

        /// <summary>
        /// Select all users
        /// </summary>
        /// <returns>a list of users</returns>
        public override List<UserInfo> SelectAll()
        {
            return list;
        }

        /// <summary>
        /// insert an user
        /// </summary>
        /// <param name="info">user to be inserted</param>
        /// <returns>ID of inserted user</returns>
        public override int Insert(UserInfo info)
        {
            if (list.Any(x => x.Login == info.Login))
            {
                return list.Find(x => x.Login == info.Login).ID.Value;
            }
            else
            {
                info.ID = NextID();
                list.Add(info);
                return info.ID.Value;
            }
        }

        /// <summary>
        /// Updates an user
        /// </summary>
        /// <param name="info">the user to be updated</param>
        public override void Update(UserInfo info)
        {
            UserInfo data = list.Find(x => x.ID == info.ID);
            if (data != null)
            {
                data = info;
            }
        }

        /// <summary>
        /// Deletes a user - Unsuported
        /// </summary>
        /// <param name="info"></param>
        public override void Delete(UserInfo info)
        {
            throw new Exception("Unsupported operation");
        }

        /// <summary>
        /// Get details of an user
        /// </summary>
        /// <param name="info">the uncompleted user's info</param>
        /// <returns>full user's info</returns>
        public override UserInfo Details(UserInfo info)
        {
            return list.Find(x => x.ID == info.ID || x.Login == info.Login);
        }
    }
}
