using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes.Entities
{
    public class Station
    {
        /// <summary>
        /// CityBikes station id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Station name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Latitude in E6 format
        /// </summary>
        public int Lat { get; set; }
        /// <summary>
        /// Longitude in E6 format
        /// </summary>
        public int Lng { get; set; }
        /// <summary>
        /// Number of bikes in the station
        /// </summary>
        public int Bikes { get; set; }
        /// <summary>
        /// Number of free slots
        /// </summary>
        public int Free { get; set; }
        /// <summary>
        /// The last time the station has been updated
        /// </summary>
        public DateTime Timestamp { get; set; }
        public int Idx { get; set; }
        public int Number { get; set; }
    }
}
