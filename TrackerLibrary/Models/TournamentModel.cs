using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TournamentModel
        {
        /// <summary>
        /// Represent The Name of the Tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represent Entry fee to the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represent the teams that have entered the competition
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represent the prize that team has won
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represent the round/stage of the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
