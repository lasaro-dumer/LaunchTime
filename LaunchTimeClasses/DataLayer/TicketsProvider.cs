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
    /// Singleton provider for tickets
    /// </summary>
    public class TicketsProvider : BasicProvider<TicketInfo>
    {
        private List<TicketInfo> list = null;
        private static TicketsProvider instance = null;
        private static String basicTicketSelect = null;

        /// <summary>
        /// Private constructor
        /// </summary>
        private TicketsProvider()
        {
            list = new List<TicketInfo>();
            basicTicketSelect = "SELECT Tickets.IDPoll, Tickets.IDRestaurant, Tickets.IDUser, Tickets.ID, " +
                                "Restaurants.Name AS NameRestaurant, " +
                                "Polls.Closed, Polls.Date, " +
                                "Users.Name AS NameUser, Users.Login " +
                                "FROM Tickets " +
                                "INNER JOIN Polls ON Polls.ID = Tickets.IDPoll " +
                                "INNER JOIN Restaurants ON Tickets.IDRestaurant = Restaurants.ID " +
                                "INNER JOIN Users ON Tickets.IDUser = Users.ID";
        }

        /// <summary>
        /// Gets singleton's instance
        /// </summary>
        public static TicketsProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new TicketsProvider();
                return instance;
            }
        }

        /// <summary>
        /// Select all tickets
        /// </summary>
        /// <returns>a list of tickets</returns>
        public override List<TicketInfo> SelectAll()
        {
            list.Clear();
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = basicTicketSelect;
                SqlCeDataReader dReader = command.ExecuteReader();
                while (dReader.Read())
                {
                    list.Add(DataToInfo(dReader));
                }
            }
            return list;
        }

        /// <summary>
        /// Select tickets of an user
        /// </summary>
        /// <param name="userInfo">user info to filter tickets</param>
        /// <returns>a list of tickets</returns>
        public List<TicketInfo> SelectByUser(UserInfo userInfo)
        {
            List<TicketInfo> byUser = new List<TicketInfo>();
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = basicTicketSelect + " WHERE IDUser = @User";
                command.Parameters.Add("@User", userInfo.ID);
                SqlCeDataReader dReader = command.ExecuteReader();
                while (dReader.Read())
                {
                    byUser.Add(DataToInfo(dReader));
                }
            }
            return byUser;
        }

        /// <summary>
        /// insert a tickert
        /// </summary>
        /// <param name="info">ticket to be inserted</param>
        /// <returns>ID of inserted ticket</returns>
        public override int Insert(TicketInfo info)
        {
            info = this.Details(info);
            if (!info.ID.HasValue)
            {
                using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCeCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO Tickets (IDPoll,IDUser,IDRestaurant) VALUES (@Poll,@User,@Restaurant)";
                    command.Parameters.Add("@Poll", info.Poll.ID);
                    command.Parameters.Add("@User", info.User.ID);
                    command.Parameters.Add("@Restaurant", info.Restaurant.ID);
                    if (command.ExecuteNonQuery() != 1)
                        return 0;
                }
                info = this.Details(info);
                list.Add(info);
            }
            return info.ID.Value;
        }

        /// <summary>
        /// Update a ticket - Unsuported
        /// </summary>
        /// <param name="info">the ticket to be updated</param>
        public override void Update(TicketInfo info)
        {
            throw new Exception("Unsupported operation");
        }

        /// <summary>
        /// Delete a ticket - Unsuported
        /// </summary>
        /// <param name="info">the ticket to be deleted</param>
        public override void Delete(TicketInfo info)
        {
            throw new Exception("Unsupported operation");
        }

        /// <summary>
        /// Get details of a ticket
        /// </summary>
        /// <param name="info">the uncompleted ticket's info</param>
        /// <returns>full tickets's info</returns>
        public override TicketInfo Details(TicketInfo info)
        {
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = basicTicketSelect + " WHERE IDPoll = @Poll AND IDUser = @User";
                if (info.ID.HasValue)
                {
                    command.CommandText += " OR ID = @ID";
                    command.Parameters.Add("@ID", info.ID);
                }
                command.Parameters.Add("@Poll", info.Poll.ID);
                command.Parameters.Add("@User", info.User.ID);
                SqlCeDataReader dReader = command.ExecuteReader();
                if (dReader.Read())
                    info = DataToInfo(dReader);
            }
            return info;
        }

        //TODO: summary
        public override TicketInfo DataToInfo(System.Data.SqlServerCe.SqlCeDataReader dr)
        {
            TicketInfo info = new TicketInfo();
            if (ColumnExists(dr, "ID"))
                info.ID = Convert.ToInt32(dr["ID"]);
            if (ColumnExists(dr, "IDPoll"))
            {
                info.Poll = new PollInfo();
                info.Poll.ID = Convert.ToInt32(dr["IDPoll"]);
                if (ColumnExists(dr, "Closed") && ColumnExists(dr, "Date"))
                {
                    info.Poll.Closed = (bool)(dr["Closed"]);
                    info.Poll.Date = (DateTime)(dr["Date"]);
                }
            }
            if (ColumnExists(dr, "IDUser"))
            {
                info.User = new UserInfo();
                info.User.ID = Convert.ToInt32(dr["IDUser"]);
                if (ColumnExists(dr, "NameUser") && ColumnExists(dr, "Login"))
                {
                    info.User.Name = dr["NameUser"].ToString();
                    info.User.Login = dr["Login"].ToString();
                }
            }
            if (ColumnExists(dr, "IDRestaurant"))
            {
                info.Restaurant = new RestaurantInfo();
                info.Restaurant.ID = Convert.ToInt32(dr["IDRestaurant"]);
                if (ColumnExists(dr, "NameRestaurant"))
                {
                    info.Restaurant.Name = dr["NameRestaurant"].ToString();
                }
            }
            return info;
        }

        //TODO: summary
        public List<TicketInfo> SelectByPoll(PollInfo poll)
        {
            List<TicketInfo> byPoll = new List<TicketInfo>();
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = basicTicketSelect + " WHERE IDPoll = @Poll";
                command.Parameters.Add("@Poll", poll.ID);
                SqlCeDataReader dReader = command.ExecuteReader();
                while (dReader.Read())
                {
                    byPoll.Add(DataToInfo(dReader));
                }
            }
            return byPoll;
        }
    }
}
