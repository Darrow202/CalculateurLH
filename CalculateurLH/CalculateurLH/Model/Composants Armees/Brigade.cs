using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model
{
    /// <summary>
    /// Classe qui gère les brigades
    /// </summary>
    public class Brigade
    {
        /// <summary>
        /// Renvoie ou modifie le nom de la brigade
        /// </summary>
        public string Nom {  get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des régiments contenus dans la brigade
        /// </summary>
        public List<IBataillon> Regiments { get; set; }

        /// <summary>
        /// Renvoie ou modifie le cout de la brigade
        /// </summary>
        public int Cout { get; set; }
    }
}
