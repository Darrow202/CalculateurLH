using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Composants_Armees
{
    /// <summary>
    /// Classe qui gère les divisions
    /// </summary>
    public class Division
    {
        #region --- Attributs ---
        private string nom;
        private List<Brigade> brigades;
        private List<Regiment> regiments;
        private List<Batterie> batteries;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="nom">Nom de la division</param>
        public Division(string nom)
        {
            this.nom = nom;
            this.brigades = new List<Brigade>();
            this.regiments = new List<Regiment>();
            this.batteries = new List<Batterie>();
        }
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Renvoie ou modifie le nom de la division
        /// </summary>
        public string Nom
        {
            get
            {
                return this.nom;
            }

            set
            {
                this.nom = value;
            }
        }

        /// <summary>
        /// Renvoie ou modifie la liste des brigades contenues dans la division
        /// </summary>
        public List<Brigade> Brigades
        {
            get
            {
                return this.brigades;
            }

            set
            {
                this.brigades = value;
            }
        }

        /// <summary>
        /// Renvoie ou modifie la liste des régiments contenus dans la division
        /// </summary>
        public List<Regiment> Regiments
        {
            get
            {
                return this.regiments;
            }

            set
            {
                this.regiments = value;
            }
        }

        /// <summary>
        /// Renvoie ou modifie la liste des batteries d'artilleries contenues dans la division
        /// </summary>
        public List<Batterie> Batteries
        {
            get
            {
                return this.batteries;
            }

            set
            {
                this.batteries = value;
            }
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Renvoie ou modifie le cout de la division
        /// </summary>
        public int Cout()
        {
            int total = 0;

            foreach(Brigade brigade in brigades)
            {
                total += brigade.Cout();
            }

            foreach(Regiment regiment in regiments)
            {
                total += regiment.Cout();
            }

            foreach(Batterie batterie in batteries)
            {
                total += batterie.Cout();
            }

            return total;
        }
        #endregion
    }
}
