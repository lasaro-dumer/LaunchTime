using LTDataLayer.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.ControlLayer
{
    /// <summary>
    /// Business controller for polls
    /// </summary>
    public class PollsController
    {
        /// <summary>
        /// Insert/Get today's poll
        /// </summary>
        /// <returns></returns>
        public static PollInfo CurrentPoll()
        {
            return PollFromDate(DateTime.Today);
        }

        /// <summary>
        /// Insert/Get a poll from a desired date
        /// </summary>
        /// <param name="date">date desired of the poll</param>
        /// <returns>The poll</returns>
        public static PollInfo PollFromDate(DateTime date)
        {
            PollsProvider.Instance.Insert(new PollInfo() { Date = date });
            return PollsProvider.Instance.Details(new PollInfo() { Date = date });
        }

        /// <summary>
        /// Processes vote from a ticket
        /// </summary>
        /// <param name="ticket">a ticket voting in a poll</param>
        public static void Vote(TicketInfo ticket)
        {
            if (ticket.Poll.Closed)
                throw new Exception("Poll closed");
            List<TicketInfo> userTickets = TicketsProvider.Instance.SelectByUser(ticket.User);
            if (userTickets.Any(t => t.Poll.ID == ticket.Poll.ID))
            {
                throw new Exception("User already voted in this poll");
            }

            TicketsProvider.Instance.Insert(ticket);
            ticket.Poll.AddVote(ticket);
        }

        /// <summary>
        /// Update a poll
        /// </summary>
        /// <param name="PollInfo">the poll to be updated</param>
        public static void Update(PollInfo PollInfo)
        {
            PollsProvider.Instance.Update(PollInfo);
        }

        /// <summary>
        /// List all polls
        /// </summary>
        /// <returns>a list of polls</returns>
        public static List<PollInfo> ListAll()
        {
            return PollsProvider.Instance.SelectAll();
        }
    }
}
