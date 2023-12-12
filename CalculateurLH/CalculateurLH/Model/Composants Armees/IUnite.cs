using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateurLH.Model.Regles;

namespace CalculateurLH.Model
{
    /// <summary>
    /// Classe qui gère les différentes unités
    /// </summary>
    public interface IUnite
    {
        #region --- Attributs ---
        /// <summary>
        /// Renvoie ou modifie le type de l'unité
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Renvoie ou modifie le type de l'unité
        /// </summary>
        public string[] TypeCompagnies { get; set; }

        /// <summary>
        /// Renvoie ou modifie le nombre de figurines par compagnies
        /// </summary>
        public int NbFigurinesCompagnies { get; set; }

        /// <summary>
        /// Renvoie ou modifie le nombre de compagnies dans l'unité
        /// </summary>
        public int[] NbCompagnies { get; set; }

        /// <summary>
        /// Renvoie ou modifie l'instruction de l'unité
        /// </summary>
        public int[] Instruction {  get; set; }

        /// <summary>
        /// Renvoie ou modifie la discipline de l'unité
        /// </summary>
        public int[] Discipline {  get; set; }

        /// <summary>
        /// Renvoie ou modifie le physique de l'unité
        /// </summary>
        public int[] Physique { get; set; }

        /// <summary>
        /// Renvoie ou modifie la psycologie de l'unité
        /// </summary>
        public int[] Psycologie { get; set; }

        /// <summary>
        /// Renvoie ou modifie le mouvement de l'unité
        /// </summary>
        public string[] Mouvement { get; set; }

        /// <summary>
        /// Renvoie ou modifie la classe de l'unité
        /// </summary>
        public string Classe {  get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des règles de l'unité
        /// </summary>
        public List<IRegle> Regles { get; set; }
        #endregion

        /// <summary>
        /// Renvoie ou modifie le cout de l'unité
        /// </summary>
        public int Cout {  get; set; }
    }

    public interface ICreateUnite
    {
        public IUnite CreateUnite();
    }
}
