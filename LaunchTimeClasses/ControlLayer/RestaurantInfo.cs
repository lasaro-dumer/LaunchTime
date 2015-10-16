using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchTimeClasses.ControlLayer
{
    /// <summary>
    /// Represents a Restaurant
    /// </summary>
    public class RestaurantInfo
    {
        /// <summary>
        /// Restaurant's ID
        /// </summary>
        public int? ID { get; set; }
        /// <summary>
        /// Restaurant's Name
        /// </summary>
        public String Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
