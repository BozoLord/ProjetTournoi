using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Représente le tournoi
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Nom du tournoi
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Prix d'inscription au tournoi
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Liste des team participantes
        /// </summary>
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Liste des prix à gagner
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Liste des listes de rounds (schéma bracket)
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }

  
}
