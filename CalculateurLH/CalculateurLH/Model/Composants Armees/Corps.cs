using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Composants_Armees
{
    /// <summary>
    /// Classe qui gère les corps d'armée
    /// </summary>
    public class Corps
    {
        #region --- Attributs ---
        private string nom;
        private List<Division> divisions;
        private List<Brigade> brigades;
        private List<Regiment> regiments;
        private List<Batterie> batteries;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="nom">Nom du corps d'armée</param>
        public Corps(string nom) 
        {
            this.nom = nom;
            this.divisions = new List<Division>();
            this.brigades = new List<Brigade>();
            this.regiments = new List<Regiment>();
            this.batteries = new List<Batterie>();
        }
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Modifie ou renvoie le nom du corps d'armée
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
        /// Renvoie ou modifie la liste des divisions contenues dans le corps
        /// </summary>
        public List<Division> Divisions
        {
            get
            {
                return this.divisions;
            }

            set
            {
                this.divisions = value;
            }
        }

        /// <summary>
        /// Renvoie ou modifie la liste des brigades contenues dans le corps 
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
        /// Renvoie ou modifie la liste des régiments contenus dans le corps
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
        /// Renvoie ou modifie la liste des batteries d'artillerie contenues dans le corps
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
        /// Renvoie ou modifie le cout du corps d'armée
        /// </summary>
        public int Cout()
        {
            int total = 0;

            foreach(Division division in this.divisions)
            {
                total += division.Cout();
            }

            foreach(Brigade brigade  in this.brigades)
            {
                total += brigade.Cout();
            }

            foreach(Regiment regiment in this.regiments)
            {
                total += regiment.Cout();
            }

            foreach(Batterie batterie in this.batteries)
            {
                total += batterie.Cout();
            }

            return total;
        }
        #endregion
    }
}
