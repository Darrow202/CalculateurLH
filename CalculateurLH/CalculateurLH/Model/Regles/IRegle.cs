using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Regles
{
    /// <summary>
    /// Classe qui gère les règles spéciales des unités
    /// </summary>
    public interface IRegle
    {
        /// <summary>
        /// Renvoie ou modifie le nom de la règle
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Renvoie ou modifie la description de la règle
        /// </summary>
        public string Description { get; set; }
    }
}
