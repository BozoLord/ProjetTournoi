using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Représente un match du tournoi
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Représente les équipes impliquées dans ce match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Gagnant du match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Représente de quel manche ce match fait partie
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
