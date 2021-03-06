﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
    /// <summary>
    /// Represent one match in the tournament
    /// </summary>
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The set of teams that were involved
        /// </summary>
        public List<MatchEntryModel> Entries { get; set; } = new List<MatchEntryModel>();
        /// <summary>
        /// Represent the match winner
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round/stage this match is part of.
        /// </summary>

        public int MatchRound { get; set; }
    }
}
