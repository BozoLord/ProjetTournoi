using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represente une team dans le matchup
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represente une team dans le matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Représente le score de cette team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Représente le match que cette équipe vient de gagner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
