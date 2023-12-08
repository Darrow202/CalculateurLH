using CalculateurLH.Model.Regles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Composants_Armees
{
    /// <summary>
    /// Interface qui gère les différents canons
    /// </summary>
    public interface ICanon
    {
        /// <summary>
        /// Renvoie ou modifie le type du canon
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Renvoie ou modifie le calibre du canon
        /// </summary>
        public int Calibre { get; set; }

        /// <summary>
        /// Renvoie ou modifie la portee du canon
        /// </summary>
        public int Portee { get; set; }

        /// <summary>
        /// Renvoie ou modifie l'instruction du canon
        /// </summary>
        public int[] Instruction { get; set; }

        /// <summary>
        /// Renvoie ou modifie la discipline du canon
        /// </summary>
        public int[] Discipline { get; set; }

        /// <summary>
        /// Renvoie ou modifie le physique du canon
        /// </summary>
        public int[] Physique { get; set; }

        /// <summary>
        /// Renvoie ou modifie la psycologie du canon
        /// </summary>
        public int[] Psycologie { get; set; }

        /// <summary>
        /// Renvoie ou modifie le mouvement du canon
        /// </summary>
        public int[] Mouvement { get; set; }

        /// <summary>
        /// Renvoie ou modifie la classe du canon
        /// </summary>
        public string Classe { get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des règles du canon
        /// </summary>
        public List<IRegle> Regles { get; set; }

        /// <summary>
        /// Renvoie ou modifie le cout du canon
        /// </summary>
        public int Cout { get; set; }
    }
}
