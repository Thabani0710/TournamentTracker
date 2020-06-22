using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {

        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represent First Name of the team member
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represent Last Name of the team member
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represent email address of the team member
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represent cellphone number of the team member
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
