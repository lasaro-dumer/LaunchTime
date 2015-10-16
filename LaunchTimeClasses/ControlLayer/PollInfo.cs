using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.ControlLayer
{
    /// <summary>
    /// Represents a Poll
    /// </summary>
    public class PollInfo
    {
        /// <summary>
        /// Poll's ID
        /// </summary>
        public int? ID { get; set; }
        /// <summary>
        /// Poll's Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Tells if the poll is closed
        /// </summary>
        public bool Closed { get; set; }
        private List<TicketInfo> _votes;
        /// <summary>
        /// Get the poll's votes
        /// </summary>
        public List<TicketInfo> Votes { get { return _votes; } }

        /// <summary>
        /// Get the poll's winner
        /// </summary>
        public RestaurantInfo Winner { get; set; }

        /// <summary>
        /// Get the poll's week of the year
        /// </summary>
        public int Week { get { return (new GregorianCalendar()).GetWeekOfYear(Date, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday); } }

        /// <summary>
        /// Creates a Poll object
        /// </summary>
        public PollInfo()
        {
            _votes = new List<TicketInfo>();
            Closed = false;
        }
        
        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Add a vote the this poll
        /// </summary>
        /// <param name="ticket">the ticket of the vote</param>
        public void AddVote(TicketInfo ticket)
        {
            _votes.Add(ticket);
        }
    }
}
