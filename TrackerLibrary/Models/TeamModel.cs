using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Représente une équipe
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Liste des membres de l'équipe
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Nom de l'équipe
        /// </summary>
        public string TeamName { get; set; }

    }
}
