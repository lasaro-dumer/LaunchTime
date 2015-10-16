using LTDataLayer.ControlLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

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
            list = new List<UserInfo>();
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
            list.Clear();
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = "SELECT ID,Name,Login FROM USERS";
                SqlCeDataReader dReader = command.ExecuteReader();
                while (dReader.Read())
                {
                    list.Add(DataToInfo(dReader));
                }
            }
            return list;
        }

        /// <summary>
        /// Get an user info from the current SqlCeDataReader row
        /// </summary>
        /// <param name="dr">a data reader</param>
        /// <returns>a new UserInfo</returns>
        public override UserInfo DataToInfo(SqlCeDataReader dr)
        {
            UserInfo info = new UserInfo();
            if (ColumnExists(dr, "ID"))
                info.ID = Convert.ToInt32(dr["ID"]);
            if (ColumnExists(dr, "Name"))
                info.Name = dr["Name"].ToString();
            if (ColumnExists(dr, "Login"))
                info.Login = dr["Login"].ToString();
            return info;
        }

        /// <summary>
        /// insert an user
        /// </summary>
        /// <param name="info">user to be inserted</param>
        /// <returns>ID of inserted user</returns>
        public override int Insert(UserInfo info)
        {
            info = this.Details(info);
            if (!info.ID.HasValue)
            {
                using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCeCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO Users (Name,Login) VALUES (@Name,@Login)";
                    command.Parameters.Add("@Name", info.Name);
                    command.Parameters.Add("@Login", info.Login);
                    if (command.ExecuteNonQuery() != 1)
                        return 0;
                }
                info = this.Details(info);
                list.Add(info);
            }
            return info.ID.Value;
        }

        /// <summary>
        /// Updates an user
        /// </summary>
        /// <param name="info">the user to be updated</param>
        public override void Update(UserInfo info)
        {
            if (info.ID.HasValue)
            {
                using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCeCommand command = conn.CreateCommand();
                    command.CommandText = "UPDATE Users SET Name=@Name,Login=@Login WHERE ID = @ID";
                    command.Parameters.Add("@Name", info.Name);
                    command.Parameters.Add("@Login", info.Login);
                    command.Parameters.Add("@ID", info.ID);
                    command.ExecuteNonQuery();
                }
                info = this.Details(info);
                list.Add(info);
            }
            else
            {
                this.Insert(info);
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
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = "SELECT ID,Name,Login FROM USERS WHERE Login = @Login";
                if (info.ID.HasValue)
                {
                    command.CommandText += " OR ID = @ID";
                    command.Parameters.Add("@ID", info.ID);
                }
                command.Parameters.Add("@Login", info.Login);
                SqlCeDataReader dReader = command.ExecuteReader();
                if (dReader.Read())
                    info = DataToInfo(dReader);
            }
            return info;
        }
    }
}
