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
        private static int nbBrigades;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// COnstructeur de la classe, ajoute 1 au nombre de brigades
        /// </summary>
        /// <param name="nom">Nom de la brigade</param>
        public Brigade(string nom)
        {
            this.nom = nom;
            this.regiments = new List<Regiment>();
            this.batteries = new List<Batterie>();
            nbBrigades += 1;
        }
        #endregion

        #region --- Destructeur ---

        /// <summary>
        /// Destructeur de la classe, réduit de 1 le nombre de brigades
        /// </summary>
        ~Brigade()
        {
            nbBrigades -= 1;
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

        /// <summary>
        /// Renvoie le nombre total de brigades
        /// </summary>
        public int NbBrigades
        {
            get
            {
                return nbBrigades;
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

        /// <summary>
        /// Ajoute un régiment à la liste de la brigade, s'il y en a moins de 3
        /// </summary>
        /// <param name="regiment">Regiement que l'on veut ajouter</param>
        public void AjouterRegiment(Regiment regiment)
        {
            if (this.regiments.Count < 3)
            {
                if (regiment.estAjoutable() == true)
                {
                    this.regiments.Add(regiment);
                }
            }
        }

        /// <summary>
        /// Ajoute une batterie d'artillerie à la liste de la brigade
        /// </summary>
        /// <param name="batterie"></param>
        public void AjouterBatterie(Batterie batterie)
        {
            this.batteries.Add(batterie);
        }
        #endregion
    }
}