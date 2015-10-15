using LTDataLayer.ControlLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.DataLayer
{
    /// <summary>
    /// Singleton provider for restaurants
    /// </summary>
    public class RestaurantsProvider : BasicProvider<RestaurantInfo>
    {
        private List<RestaurantInfo> list = null;
        private static RestaurantsProvider instance = null;

        /// <summary>
        /// Private constructor
        /// </summary>
        private RestaurantsProvider()
        {
            list = new List<RestaurantInfo>();
            this.Insert(new RestaurantInfo() { Name = "Palatus" });
            this.Insert(new RestaurantInfo() { Name = "Dinner 2nd St" });
            this.Insert(new RestaurantInfo() { Name = "Corner's Dinner" });
            this.Insert(new RestaurantInfo() { Name = "Vito's Pizza" });
            this.Insert(new RestaurantInfo() { Name = "John's Burger" });
            this.Insert(new RestaurantInfo() { Name = "McDonalds" });
            this.Insert(new RestaurantInfo() { Name = "Subway" });
            this.Insert(new RestaurantInfo() { Name = "Momma's Food" });
            this.Insert(new RestaurantInfo() { Name = "China in Box" });
        }

        /// <summary>
        /// get singleton's instance
        /// </summary>
        public static RestaurantsProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new RestaurantsProvider();
                return instance;
            }
        }

        /// <summary>
        /// Select all restaurants
        /// </summary>
        /// <returns>a list of restaurants</returns>
        public override List<RestaurantInfo> SelectAll()
        {
            return list;
        }

        /// <summary>
        /// Insert a Restaurant
        /// </summary>
        /// <param name="info">restaurant to be inserted</param>
        /// <returns>inserted restaurant ID</returns>
        public override int Insert(RestaurantInfo info)
        {
            if (list.Any(x => x.Name == info.Name))
            {
                return list.Find(x => x.Name == info.Name).ID.Value;
            }
            else
            {
                info.ID = NextID();
                list.Add(info);
                return info.ID.Value;
            }
        }

        /// <summary>
        /// Update a restaurant
        /// </summary>
        /// <param name="info">restaurant's info to be updated</param>
        public override void Update(RestaurantInfo info)
        {
            RestaurantInfo data = list.Find(x => x.ID == info.ID);
            if (data != null)
            {
                data = info;
            }
        }

        /// <summary>
        /// Delete a restaurant - Unsuported
        /// </summary>
        /// <param name="info"></param>
        public override void Delete(RestaurantInfo info)
        {
            throw new Exception("Unsupported operation");
        }

        /// <summary>
        /// Get details of a restaurant
        /// </summary>
        /// <param name="info">the uncompleted restaurant's info</param>
        /// <returns>full restaurant's info</returns>
        public override RestaurantInfo Details(RestaurantInfo info)
        {
            return list.Find(x => x.ID == info.ID || x.Name == info.Name);
        }

        public override RestaurantInfo DataToInfo(System.Data.SqlServerCe.SqlCeDataReader dr)
        {
            throw new NotImplementedException();
        }
    }
}
