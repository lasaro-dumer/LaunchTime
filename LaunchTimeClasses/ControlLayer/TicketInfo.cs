using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.ControlLayer
{
    /// <summary>
    /// Represents a ticket voting in a poll
    /// </summary>
    public class TicketInfo
    {
        /// <summary>
        /// Ticket's ID
        /// </summary>
        public int? ID { get; set; }
        /// <summary>
        /// Ticket's Poll
        /// </summary>
        public PollInfo Poll { get; set; }
        /// <summary>
        /// Ticket's Restaurant
        /// </summary>
        public RestaurantInfo Restaurant { get; set; }
        /// <summary>
        /// Ticket's User
        /// </summary>
        public UserInfo User { get; set; }

        public override string ToString()
        {
            return ID + "[" + Poll + "-" + Restaurant + "-" + User + "]";
        }
    }
}
