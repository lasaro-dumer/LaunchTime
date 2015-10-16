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
    /// Singleton Provider for polls
    /// </summary>
    public class PollsProvider : BasicProvider<PollInfo>
    {
        private static PollsProvider instance = null;
        private List<PollInfo> list = null;

        /// <summary>
        /// Private constructor
        /// </summary>
        private PollsProvider()
        {
            list = new List<PollInfo>();
        }

        /// <summary>
        /// Gets singleton's instance
        /// </summary>
        public static PollsProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new PollsProvider();
                return instance;
            }
        }

        /// <summary>
        /// Select all polls
        /// </summary>
        /// <returns>a list of polls</returns>
        public override List<PollInfo> SelectAll()
        {
            list.Clear();
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = "SELECT ID,Date,Closed FROM Polls";
                SqlCeDataReader dReader = command.ExecuteReader();
                while (dReader.Read())
                {
                    list.Add(DataToInfo(dReader));
                }
            }
            return list;
        }

        /// <summary>
        /// insert a poll
        /// </summary>
        /// <param name="info">poll to be inserted</param>
        /// <returns>ID of inserted poll</returns>
        public override int Insert(PollInfo info)
        {
            info = this.Details(info);
            if (!info.ID.HasValue)
            {
                using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCeCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO Polls (Date,Closed) VALUES (@Date,@Closed)";
                    command.Parameters.Add("@Date", info.Date.Date);
                    command.Parameters.Add("@Closed", false);
                    if (command.ExecuteNonQuery() != 1)
                        return 0;
                }
                info = this.Details(info);
                list.Add(info);
            }
            return info.ID.Value;
        }

        /// <summary>
        /// Updates a poll - Unsuported
        /// </summary>
        /// <param name="info">the poll to be updated</param>
        public override void Update(PollInfo info)
        {
            if (info.ID.HasValue)
            {
                using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCeCommand command = conn.CreateCommand();
                    command.CommandText = "UPDATE Polls SET Closed=@Closed WHERE ID = @ID";
                    command.Parameters.Add("@Closed", info.Closed);
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
        /// Delete a poll - Unsuported
        /// </summary>
        /// <param name="info">the poll to be deleted</param>
        public override void Delete(PollInfo info)
        {
            throw new Exception("Unsupported operation");
        }

        /// <summary>
        /// Get details of a poll
        /// </summary>
        /// <param name="info">the uncompleted poll's info</param>
        /// <returns>full poll's info</returns>
        public override PollInfo Details(PollInfo info)
        {
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = "SELECT ID,Date,Closed FROM Polls WHERE Date = @Date";
                if (info.ID.HasValue)
                {
                    command.CommandText += " OR ID = @ID";
                    command.Parameters.Add("@ID", info.ID);
                }
                command.Parameters.Add("@Date", info.Date.Date);
                SqlCeDataReader dReader = command.ExecuteReader();
                if (dReader.Read())
                    info = DataToInfo(dReader);
            }
            return info;
        }

        /// <summary>
        /// Selects a list of polls from the week of base date
        /// </summary>
        /// <param name="baseDate">base date</param>
        /// <returns>a list of polls</returns>
        public List<PollInfo> SelectByWeek(DateTime baseDate)
        {
            List<PollInfo> byWeek = new List<PollInfo>();
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = "SELECT ID,Date,Closed FROM Polls WHERE Date BETWEEN @FirstDay AND @LastDay";
                DateTime firstDay = baseDate.AddDays((int)baseDate.DayOfWeek * -1);
                DateTime lastDay = baseDate.AddDays(-1);
                command.Parameters.Add("@FirstDay", firstDay.Date);
                command.Parameters.Add("@LastDay", lastDay.Date);
                SqlCeDataReader dReader = command.ExecuteReader();
                while (dReader.Read())
                {
                    byWeek.Add(DataToInfo(dReader));
                }
            }
            return byWeek;
        }

        /// <summary>
        /// Get a poll info from the current SqlCeDataReader row
        /// </summary>
        /// <param name="dr">a data reader</param>
        /// <returns>a new PollInfo</returns>
        public override PollInfo DataToInfo(SqlCeDataReader dr)
        {
            PollInfo info = new PollInfo();
            if (ColumnExists(dr, "ID"))
                info.ID = Convert.ToInt32(dr["ID"]);
            if (ColumnExists(dr, "Date"))
                info.Date = (DateTime)dr["Date"];
            if (ColumnExists(dr, "Closed"))
                info.Closed = (bool)dr["Closed"];
            return info;
        }

        /// <summary>
        /// Gets the poll's winner
        /// </summary>
        /// <param name="poll">the poll</param>
        /// <returns>poll's winner</returns>
        public RestaurantInfo GetPollWinner(PollInfo poll)
        {
            RestaurantInfo winner = null;
            using (SqlCeConnection conn = new SqlCeConnection(ConnectionString))
            {
                conn.Open();
                SqlCeCommand command = conn.CreateCommand();
                command.CommandText = "SELECT Restaurants.ID, Restaurants.Name, COUNT(*) AS Votes "+
                                      "FROM Tickets " +
                                      "INNER JOIN Polls ON Tickets.IDPoll = Polls.ID " +
                                      "INNER JOIN Restaurants ON Tickets.IDRestaurant = Restaurants.ID "+
                                      "WHERE Polls.ID = @ID " +
                                      "GROUP BY Restaurants.Name, Restaurants.ID "+
                                      "ORDER BY Votes DESC,Restaurants.ID";
                command.Parameters.Add("@ID", poll.ID);
                SqlCeDataReader dReader = command.ExecuteReader();
                if (dReader.Read())
                    winner = RestaurantsProvider.Instance.DataToInfo(dReader);
            }
            return winner;
        }
    }
}
