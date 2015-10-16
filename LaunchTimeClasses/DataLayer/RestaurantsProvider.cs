using LaunchTimeClasses.ControlLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace LaunchTimeClasses.DataLayer
{
    /// <summary>
    /// Singleton provider for restaurants
    /// </summary>
    public class RestaurantsProvider : BasicProvider<RestaurantInfo>
    {
        private List<RestaurantInfo> list = null;
        private static RestaurantsProvider instance = null;

        /// <summary>
        /// Private constructor
        /// </summary>
        private RestaurantsProvider()
        {
            list = new List<RestaurantInfo>();
        }

        /// <summary>
        /// get singleton's instance
        /// </summary>
        public static RestaurantsProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new RestaurantsProvider();
                return instance;
            }
        }

        /// <summary>
        /// Select all restaurants
        /// </summary>
        /// <returns>a list of restaurants</returns>
        public override List<RestaurantInfo> SelectAll()
        {
            list.Clear();
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = "SELECT ID,Name FROM RESTAURANTS";
                SqlCeDataReader dReader = command.ExecuteReader();
                while (dReader.Read())
                {
                    list.Add(DataToInfo(dReader));
                }
            }
            return list;
        }

        /// <summary>
        /// Insert a Restaurant
        /// </summary>
        /// <param name="info">restaurant to be inserted</param>
        /// <returns>inserted restaurant ID</returns>
        public override int Insert(RestaurantInfo info)
        {
            info = this.Details(info);
            if (!info.ID.HasValue)
            {
                using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCeCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO Restaurants (Name) VALUES (@Name)";
                    command.Parameters.Add("@Name", info.Name);
                    if (command.ExecuteNonQuery() != 1)
                        return 0;
                }
                info = this.Details(info);
                list.Add(info);
            }
            return info.ID.Value;
        }

        /// <summary>
        /// Update a restaurant
        /// </summary>
        /// <param name="info">restaurant's info to be updated</param>
        public override void Update(RestaurantInfo info)
        {
            if (info.ID.HasValue)
            {
                using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCeCommand command = conn.CreateCommand();
                    command.CommandText = "UPDATE Restaurants SET Name=@Name WHERE ID = @ID";
                    command.Parameters.Add("@Name", info.Name);
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
        /// Delete a restaurant - Unsuported
        /// </summary>
        /// <param name="info"></param>
        public override void Delete(RestaurantInfo info)
        {
            throw new Exception("Unsupported operation");
        }

        /// <summary>
        /// Get details of a restaurant
        /// </summary>
        /// <param name="info">the uncompleted restaurant's info</param>
        /// <returns>full restaurant's info</returns>
        public override RestaurantInfo Details(RestaurantInfo info)
        {
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = "SELECT ID,Name FROM Restaurants WHERE Name = @Name";
                if (info.ID.HasValue)
                {
                    command.CommandText += " OR ID = @ID";
                    command.Parameters.Add("@ID", info.ID);
                }
                command.Parameters.Add("@Name", info.Name);
                SqlCeDataReader dReader = command.ExecuteReader();
                if (dReader.Read())
                    info = DataToInfo(dReader);
            }
            return info;
        }

        /// <summary>
        /// Get a restaurant info from the current SqlCeDataReader row
        /// </summary>
        /// <param name="dr">a data reader</param>
        /// <returns>a new RestaurantInfo</returns>
        public override RestaurantInfo DataToInfo(System.Data.SqlServerCe.SqlCeDataReader dr)
        {
            RestaurantInfo info = new RestaurantInfo();
            if (ColumnExists(dr, "ID"))
                info.ID = Convert.ToInt32(dr["ID"]);
            if (ColumnExists(dr, "Name"))
                info.Name = dr["Name"].ToString();
            return info;
        }
    }
}
