using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represent the position number in the competition
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represent the position name in the competition
        /// </summary>
        public int PlaceName { get; set; }
        /// <summary>
        /// Represent the prize amount for the competition
        /// </summary>
        public int PrizeAmount { get; set; }
    }
}
