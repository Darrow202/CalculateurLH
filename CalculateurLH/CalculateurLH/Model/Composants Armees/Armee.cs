using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model
{
    /// <summary>
    /// Classe qui gère les armées
    /// </summary>
    public class Armee
    {
        /// <summary>
        /// Renvoie ou modifie le nom donné à l'armée
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des corps contenus dans l'armée
        /// </summary>
        public List<Corps> Corps { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des divisions contenus dans l'armée
        /// </summary>
        public List<Division> Divisions { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des brigades contenues dans l'armée
        /// </summary>
        public List<Brigade> Brigades { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des régiments contenues dans l'armée
        /// </summary>
        public List<IBataillon> Regiments { get; set; }

        /// <summary>
        /// Renvoie ou modifie le cout de l'armée
        /// </summary>
        public int Cout { get; set; }
    }
}
