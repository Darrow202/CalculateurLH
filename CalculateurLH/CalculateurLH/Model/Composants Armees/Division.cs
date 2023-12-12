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
        private static int nbDivisions = 0;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur de la classe, il ajoute 1 au nombre de division
        /// </summary>
        /// <param name="nom">Nom de la division</param>
        public Division(string nom)
        {
            this.nom = nom;
            this.brigades = new List<Brigade>();
            this.regiments = new List<Regiment>();
            this.batteries = new List<Batterie>();
            nbDivisions += 1;
        }
        #endregion

        #region --- Destructeur ---

        /// <summary>
        /// Destructeur de la classe, il reduit de 1 le nombre de division
        /// </summary>
        ~Division()
        {
            nbDivisions -= 1;
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

        /// <summary>
        /// Renvoie le nombre total de divisions
        /// </summary>
        public int NbDivisions
        {
            get
            {
                return nbDivisions;
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

        /// <summary>
        /// Ajoute une brigade à la liste de la division, s'il y en a moins de 3
        /// </summary>
        /// <param name="brigade">Brigade que l'on veut ajouter</param>
        public void AjouterBrigade(Brigade brigade)
        {
            if (this.brigades.Count < 3)
            {
                this.brigades.Add(brigade);
            }
        }

        /// <summary>
        /// Ajoute un régiment à la liste de la division, s'il y en a moins de 2
        /// </summary>
        /// <param name="regiment">Regiment que l'on veut ajouter</param>
        public void AjouterRegiment(Regiment regiment)
        {
            if (this.regiments.Count < 2)
            {
                if (regiment.estAjoutable() == true)
                {
                    this.regiments.Add(regiment);
                }                
            }
        }

        /// <summary>
        /// Ajoute une batterie à la liste de la division
        /// </summary>
        /// <param name="batterie">Batterie que l'on veut ajouter</param>
        public void AjouterBatterie(Batterie batterie)
        {
            this.batteries.Add(batterie);
        }
        #endregion
    }
}
