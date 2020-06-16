using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TeamModel
    {   /// <summary>
        /// Represents Members of a particular team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents Name of a team member
        /// </summary>
        public string TeamName { get; set; } 
    }
}
