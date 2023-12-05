using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Composants_Armees
{
    public class Regiment
    {
        /// <summary>
        /// Renvoie ou modifie le nom du régiment
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des bataillons de l'unité
        /// </summary>
        public List<IBataillon> Bataillons { get; set; }

        /// <summary>
        /// Renvoie ou modifie le cout du régiment
        /// </summary>
        public int Cout { get; set; }
    }
}
