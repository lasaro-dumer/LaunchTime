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
            PollInfo poll = PollsProvider.Instance.Details(new PollInfo() { Date = date });
            poll.Winner = GetPollWinner(poll);
            return poll;
        }

        /// <summary>
        /// Processes vote from a ticket
        /// </summary>
        /// <param name="ticket">a ticket voting in a poll</param>
        public static void Vote(TicketInfo ticket)
        {
            if (ticket.Poll.Closed)
                throw new Exception("Poll closed");
            List<TicketInfo> userTickets = TicketsController.SelectByUser(ticket.User);
            if (userTickets.Any(t => t.Poll.ID == ticket.Poll.ID))
            {
                throw new Exception("User already voted in this poll");
            }

            TicketsController.Insert(ticket);
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

        /// <summary>
        /// Selects a list of polls from the week of base date
        /// </summary>
        /// <param name="baseDate">base date</param>
        /// <returns>a list of polls</returns>
        public static List<PollInfo> SelectByWeek(DateTime baseDate)
        {
            List<PollInfo> polls = PollsProvider.Instance.SelectByWeek(baseDate);
            foreach (PollInfo poll in polls)
            {
                List<TicketInfo> votes = TicketsController.SelectByPoll(poll);
                foreach (TicketInfo vote in votes)
                    poll.AddVote(vote);
                poll.Winner = GetPollWinner(poll);
            }
            return polls;
        }

        /// <summary>
        /// Closes a poll
        /// </summary>
        /// <param name="poll">the poll to be closed</param>
        /// <returns>the poll with his winner evaluated</returns>
        public static PollInfo ClosePoll(PollInfo poll)
        {
            poll.Closed = true;
            Update(poll);
            poll.Winner = GetPollWinner(poll);
            return poll;
        }

        /// <summary>
        /// Gets the poll's winner
        /// </summary>
        /// <param name="poll">the poll</param>
        /// <returns>poll's winner</returns>
        public static RestaurantInfo GetPollWinner(PollInfo poll)
        {
            return PollsProvider.Instance.GetPollWinner(poll);
        }
    }
}
