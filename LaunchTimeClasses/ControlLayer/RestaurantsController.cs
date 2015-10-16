using LTDataLayer.DataLayer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.ControlLayer
{
    /// <summary>
    /// Business controller for restaurants
    /// </summary>
    public class RestaurantsController
    {
        /// <summary>
        /// Gets a list of restaurants available for votes on the week of the desired date
        /// </summary>
        /// <param name="baseDate">base date for week's calculation</param>
        /// <returns>a list of restaurants</returns>
        public static List<RestaurantInfo> AvailableThisWeek(DateTime baseDate)
        {
            List<PollInfo> weekPolls = PollsController.SelectByWeek(baseDate);
            List<RestaurantInfo> weekRestaurants = (from p in weekPolls
                                                    where p.Date.Date < baseDate.Date
                                                    select p.Winner).Where(r => r != null).ToList();
            List<RestaurantInfo> rest = RestaurantsProvider.Instance.SelectAll();
            foreach (RestaurantInfo wr in weekRestaurants)
            {
                rest.RemoveAll(r => r.ID == wr.ID);
            }
            return rest;
        }

        /// <summary>
        /// Gets a list of restaurants available for votes on the current week
        /// </summary>
        /// <returns>a list of restaurants</returns>
        public static List<RestaurantInfo> AvailableThisWeek()
        {
            return AvailableThisWeek(DateTime.Today);
        }

        /// <summary>
        /// List all restaurants
        /// </summary>
        /// <returns>a list of restaurants</returns>
        public static List<RestaurantInfo> ListAll()
        {
            return RestaurantsProvider.Instance.SelectAll();
        }
    }
}
