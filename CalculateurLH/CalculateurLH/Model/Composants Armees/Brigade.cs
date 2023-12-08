using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Composants_Armees
{
    /// <summary>
    /// Classe qui gère les brigades
    /// </summary>
    public class Brigade
    {
        #region --- Attributs ---
        private string nom;
        private List<Regiment> regiments;
        private List<Batterie> batteries;
        #endregion

        #region --- Constructeur ---
        public Brigade(string nom)
        {
            this.nom = nom;
            this.regiments = new List<Regiment>();
            this.batteries = new List<Batterie>();
        }
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Renvoie ou modifie le nom de la brigade
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
        /// Renvoie ou modifie la liste des régiments contenus dans la brigade
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
        /// Renvoie ou modifie la liste des batteries d'artilleries de la brigade 
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
        /// Renvoie ou modifie le cout de la brigade
        /// </summary>
        public int Cout()
        {
            int total = 0;

            foreach (Regiment regiment in Regiments)
            {
                total += regiment.Cout();
            }

            foreach (Batterie batterie  in Batteries)
            {
                total += batterie.Cout();
            }

            return total;
        }
        #endregion
    }
}