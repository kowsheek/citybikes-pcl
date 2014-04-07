using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityBikes.Entities
{
    public class Network
    {
        /// <summary>
        /// CityBikes id for this network
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Network idname
        /// </summary>
        public string Name { get; set; }
        public string City { get; set; }
        public string Url { get; set; }
        /// <summary>
        /// City Latitude
        /// </summary>
        public int Lat { get; set; }
        /// <summary>
        /// City Longitude
        /// </summary>
        public int Lng { get; set; }
        public int Radius { get; set; }
    }
}
