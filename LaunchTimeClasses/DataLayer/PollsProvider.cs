using LTDataLayer.ControlLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTDataLayer.DataLayer
{
    /// <summary>
    /// Singleton Provider for polls
    /// </summary>
    public class PollsProvider : BasicProvider<PollInfo>
    {
        private static PollsProvider instance = null;
        private List<PollInfo> list = null;

        /// <summary>
        /// Private constructor
        /// </summary>
        private PollsProvider()
        {
            if (list == null)
            {
                list = new List<PollInfo>();
                list.Add(new PollInfo() { ID = NextID(), Date = new DateTime(2015, 10, 1) });
                list.Add(new PollInfo() { ID = NextID(), Date = new DateTime(2015, 10, 2) });
                list.Add(new PollInfo() { ID = NextID(), Date = new DateTime(2015, 10, 5) });
                list.Add(new PollInfo() { ID = NextID(), Date = new DateTime(2015, 10, 6) });
                list.Add(new PollInfo() { ID = NextID(), Date = new DateTime(2015, 10, 7) });
                list.Add(new PollInfo() { ID = NextID(), Date = new DateTime(2015, 10, 8) });
                list.Add(new PollInfo() { ID = NextID(), Date = new DateTime(2015, 10, 9) });
                list.Add(new PollInfo() { ID = NextID(), Date = new DateTime(2015, 10, 13) });
            }
        }

        /// <summary>
        /// Gets singleton's instance
        /// </summary>
        public static PollsProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new PollsProvider();
                return instance;
            }
        }

        /// <summary>
        /// Select all polls
        /// </summary>
        /// <returns>a list of polls</returns>
        public override List<PollInfo> SelectAll()
        {
            return list;
        }

        /// <summary>
        /// insert a poll
        /// </summary>
        /// <param name="info">poll to be inserted</param>
        /// <returns>ID of inserted poll</returns>
        public override int Insert(PollInfo info)
        {
            if (list.Any(x => x.Date.Date == info.Date.Date))
            {
                return list.Find(x => x.Date.Date == info.Date.Date).ID.Value;
            }
            else
            {
                info.ID = NextID();
                list.Add(info);
                return info.ID.Value;
            }
        }

        /// <summary>
        /// Updates a poll - Unsuported
        /// </summary>
        /// <param name="info">the poll to be updated</param>
        public override void Update(PollInfo info)
        {
            throw new Exception("Unsupported operation");
        }

        /// <summary>
        /// Delete a poll - Unsuported
        /// </summary>
        /// <param name="info">the poll to be deleted</param>
        public override void Delete(PollInfo info)
        {
            throw new Exception("Unsupported operation");
        }

        /// <summary>
        /// Get details of a poll
        /// </summary>
        /// <param name="info">the uncompleted poll's info</param>
        /// <returns>full poll's info</returns>
        public override PollInfo Details(PollInfo info)
        {
            return list.Find(x => x.ID == info.ID || x.Date.Date == info.Date.Date);
        }

        /// <summary>
        /// Select polls based on a week
        /// </summary>
        /// <param name="week">week of polls to select</param>
        /// <returns>a list of polls on a week</returns>
        public List<PollInfo> SelectByWeek(int week)
        {
            return list.Where(p => p.Week == week).ToList();
        }
    }
}
