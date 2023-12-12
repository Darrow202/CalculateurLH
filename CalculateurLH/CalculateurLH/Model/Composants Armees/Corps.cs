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
        private static int nbCorps = 0;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur de la classe, il ajoute 1 au nombre de corps
        /// </summary>
        /// <param name="nom">Nom du corps d'armée</param>
        public Corps(string nom) 
        {
            this.nom = nom;
            this.divisions = new List<Division>();
            this.brigades = new List<Brigade>();
            this.regiments = new List<Regiment>();
            this.batteries = new List<Batterie>();

            nbCorps += 1;
        }
        #endregion

        #region --- Destructeur ---
        /// <summary>
        /// Destructeur de la classe, il reduit de 1 le nombre de corps
        /// </summary>
        ~Corps()
        {
            nbCorps -= 1;
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

        /// <summary>
        /// Renvoie le nombre total de corps
        /// </summary>
        public int NbCorps
        {
            get
            {
                return nbCorps;
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

        /// <summary>
        /// Ajoute une division à la liste du corps
        /// </summary>
        /// <param name="division">Division que l'on veut ajouter</param>
        public void AjouterDivision(Division division)
        {
            this.divisions.Add(division);
        }

        /// <summary>
        /// Ajoute une brigade à la liste du corps, s'il y en a moins de 2
        /// </summary>
        /// <param name="brigade">Brigade que l'on veut ajouter</param>
        public void AjouterBrigade(Brigade brigade)
        {
            if (this.brigades.Count < 2)
            {
                this.brigades.Add(brigade);
            }
        }

        /// <summary>
        /// Ajoute un régiment à la liste du corps, s'il y en a moins de 2
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
        /// Ajoute une batterie d'artillerie à la liste du corps
        /// </summary>
        /// <param name="batterie"></param>
        public void AjouterBatterie(Batterie batterie)
        {
            this.batteries.Add(batterie);
        }
        #endregion
    }
}
