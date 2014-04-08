using CityBikes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBikes
{
    public static class CityBikesHelper
    {
        public static double ConvertE6ToDecimalDegrees(int value)
        {
            return (value / 1E6);
        }

        public static string StationNameWithoutId(Station station)
        {
            var split = station.Name.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            if (split.Length == 2)
            {
                return split[1].Trim();
            }
            else
            {
                return station.Name;
            }
        }
    }
}
