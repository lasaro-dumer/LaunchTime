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
    }
}
