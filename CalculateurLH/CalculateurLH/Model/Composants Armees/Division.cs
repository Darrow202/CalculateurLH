using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model
{
    /// <summary>
    /// Classe qui gère les divisions
    /// </summary>
    public class Division
    {
        /// <summary>
        /// Renvoie ou modifie le nom de la division
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des brigades contenues dans la division
        /// </summary>
        public List<Brigade> Brigades { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des régiments contenus dans la division
        /// </summary>
        public List<IBataillon> Regiments { get; set; }

        /// <summary>
        /// Renvoie ou modifie le cout de la division
        /// </summary>
        public int Cout { get; set; }
    }
}
