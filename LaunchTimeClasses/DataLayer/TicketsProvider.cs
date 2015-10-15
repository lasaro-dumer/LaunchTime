using LTDataLayer.ControlLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.DataLayer
{
    /// <summary>
    /// Singleton provider for tickets
    /// </summary>
    public class TicketsProvider : BasicProvider<TicketInfo>
    {
        private List<TicketInfo> list = null;
        private static TicketsProvider instance = null;

        /// <summary>
        /// Private constructor
        /// </summary>
        private TicketsProvider()
        {
            list = new List<TicketInfo>();
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
            return list;
        }

        /// <summary>
        /// Select tickets of an user
        /// </summary>
        /// <param name="userInfo">user info to filter tickets</param>
        /// <returns>a list of tickets</returns>
        public List<TicketInfo> SelectByUser(UserInfo userInfo)
        {
            return list.Where(t => t.User.ID == userInfo.ID).ToList();
        }

        /// <summary>
        /// insert a tickert
        /// </summary>
        /// <param name="info">ticket to be inserted</param>
        /// <returns>ID of inserted ticket</returns>
        public override int Insert(TicketInfo info)
        {
            if (list.Any(x => x.Poll.ID == info.Poll.ID && x.User.ID == info.User.ID))
            {
                return list.Find(x => x.Poll.ID == info.Poll.ID && x.User.ID == info.User.ID).ID.Value;
            }
            else
            {
                info.ID = NextID();
                list.Add(info);
                return info.ID.Value;
            }
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
            return list.Find(x => x.ID == info.ID || (x.Poll.ID == info.Poll.ID && x.User.ID == info.User.ID));
        }

        public override TicketInfo DataToInfo(System.Data.SqlServerCe.SqlCeDataReader dr)
        {
            throw new NotImplementedException();
        }
    }
}
