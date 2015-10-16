using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchTimeClasses.ControlLayer
{
    /// <summary>
    /// Represent a User
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// User's ID
        /// </summary>
        public int? ID { get; set; }
        /// <summary>
        /// User's Name
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// User's Login
        /// </summary>
        public String Login { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
