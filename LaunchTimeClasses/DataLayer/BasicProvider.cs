using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace LaunchTimeClasses.DataLayer
{
    /// <summary>
    /// Basic provider structure
    /// </summary>
    /// <typeparam name="T">the type that the provider must manage</typeparam>
    public abstract class BasicProvider<T>
    {
        protected int _nextID = 1;
        
        /// <summary>
        /// Returns an ID and increments for the next get
        /// </summary>
        /// <returns>an ID</returns>
        protected int NextID()
        {
            int toGo = _nextID;
            _nextID++;
            return toGo;
        }

        /// <summary>
        /// Get default connection string
        /// </summary>
        protected String ConnectionString { get { return LaunchTimeClasses.Properties.Settings.Default.LaunchTimeDBConnectionString; } }

        /// <summary>
        /// Get a new object of type T from the current SqlCeDataReader row
        /// </summary>
        /// <param name="dr">a data reader</param>
        /// <returns>a new type T object</returns>
        public abstract T DataToInfo(SqlCeDataReader dr);

        /// <summary>
        /// Insert signature for providers
        /// </summary>
        /// <param name="info">info to Insert</param>
        /// <returns>suggested to return the inserted ID</returns>
        public abstract int Insert(T info);

        /// <summary>
        /// Update signature for providers
        /// </summary>
        /// <param name="info">info to Update</param>
        public abstract void Update(T info);

        /// <summary>
        /// Delete signature for providers
        /// </summary>
        /// <param name="info">info to Delete</param>
        public abstract void Delete(T info);

        /// <summary>
        /// Get details signature for providers
        /// </summary>
        /// <param name="info">info to get details</param>
        /// <returns>the info fully detailed, if found</returns>
        public abstract T Details(T info);

        /// <summary>
        /// Select signature
        /// </summary>
        /// <returns>a list of object of type T</returns>
        public abstract List<T> SelectAll();

        /// <summary>
        /// Check if a column exists in the data reader
        /// source: http://stackoverflow.com/questions/1206596/checking-to-see-if-a-column-exists-in-a-data-reader
        /// </summary>
        /// <param name="reader">the data reader</param>
        /// <param name="columnName">the column name</param>
        /// <returns>true if exists, otherwise false</returns>
        public bool ColumnExists(IDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
                if (reader.GetName(i) == columnName)
                    return true;
            return false;
        }
    }
}
