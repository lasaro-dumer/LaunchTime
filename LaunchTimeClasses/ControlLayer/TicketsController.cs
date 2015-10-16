using LTDataLayer.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.ControlLayer
{
    /// <summary>
    /// Business Controller for tickets
    /// </summary>
    public class TicketsController
    {
        /// <summary>
        /// List all tickets
        /// </summary>
        /// <returns>a list of tickets</returns>
        public static List<TicketInfo> ListAll()
        {
            return TicketsProvider.Instance.SelectAll();
        }

        /// <summary>
        /// Select tickets of a poll
        /// </summary>
        /// <param name="poll">the ticket's poll</param>
        /// <returns>a list of tickets from poll</returns>
        public static List<TicketInfo> SelectByPoll(PollInfo poll)
        {
            return TicketsProvider.Instance.SelectByPoll(poll);
        }
        
        /// <summary>
        /// Select tickets of a user
        /// </summary>
        /// <param name="userInfo">the user of the tickets</param>
        /// <returns>a list of ticker from the user</returns>
        public static List<TicketInfo> SelectByUser(UserInfo userInfo)
        {
            return TicketsProvider.Instance.SelectByUser(userInfo);
        }

        /// <summary>
        /// Insert a ticket
        /// </summary>
        /// <param name="ticket">ticket to be inserted</param>
        public static void Insert(TicketInfo ticket)
        {
            ticket.ID = TicketsProvider.Instance.Insert(ticket);
        }
    }
}
