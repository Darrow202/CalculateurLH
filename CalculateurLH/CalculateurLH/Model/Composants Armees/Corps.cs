using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model
{
    /// <summary>
    /// Classe qui gère les corps d'armée
    /// </summary>
    public class Corps
    {
        /// <summary>
        /// Modifie ou renvoie le nom du corps d'armée
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des divisions contenues dans le corps
        /// </summary>
        public List<Division> Divisions { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des brigades contenues dans le corps 
        /// </summary>
        public List<Brigade> Brigades { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des régiments contenus dans le corps
        /// </summary>
        public List<IBataillon> Regiments { get; set; }

        /// <summary>
        /// Renvoie ou modifie le cout du corps d'armée
        /// </summary>
        public int Cout { get; set; }
    }
}
