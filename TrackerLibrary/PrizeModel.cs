using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Represent the position number in the competition
        /// </summary> 
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represent the position name in the competition(first place, runner up)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represent the prize amount for the competition or 0 if not used
        /// </summary>
        public int PrizeAmount { get; set; }
        /// <summary>
        /// The number that represents the percentage of the overall take
        /// or 0 if not useed. The percentage is a fraction of 1 (so 0.5 for 50 %)
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
