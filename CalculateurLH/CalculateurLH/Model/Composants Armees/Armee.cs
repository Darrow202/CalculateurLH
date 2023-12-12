using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Composants_Armees
{
    /// <summary>
    /// Classe qui gère les armées
    /// </summary>
    public class Armee
    {
        #region --- Attributs ---
        private string nom;
        private List<Corps> corps;
        private List<Division> divisions;
        private List<Brigade> brigades;
        private List<Regiment> regiments;
        private List<Batterie> batteries;
        #endregion

        #region ---Constructeur ---
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="nom">Nom de l'armée</param>
        public Armee(string nom)
        {
            this.nom = nom;
            this.corps = new List<Corps>();
            this.divisions = new List<Division>();
            this.brigades = new List<Brigade>();
            this.regiments = new List<Regiment>();
            this.batteries = new List<Batterie>();
        }
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Renvoie ou modifie le nom donné à l'armée
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
        /// Renvoie ou modifie la liste des corps contenus dans l'armée
        /// </summary>
        public List<Corps> Corps
        {
            get
            {
                return this.corps;
            }

            set
            {
                this.corps = value;
            }
        }

        /// <summary>
        /// Renvoie ou modifie la liste des divisions contenus dans l'armée
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
        /// Renvoie ou modifie la liste des brigades contenues dans l'armée
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
        /// Renvoie ou modifie la liste des régiments contenues dans l'armée
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
        /// Renvoie ou modifie la liste des batteries d'artillerie de l'armée
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
        /// Renvoie le cout de l'armée en le calculant avec les couts de tous ses composants
        /// </summary>
        public int Cout()
        {
            int total = 0;

            foreach (Corps corps in this.corps)
            {
                total += corps.Cout();
            }

            foreach (Division division in this.divisions)
            {
                total += division.Cout();
            }

            foreach (Brigade brigade in this.brigades)
            {
                total += brigade.Cout();
            }

            foreach (Regiment regiment in this.regiments)
            {
                total += regiment.Cout();
            }

            foreach (Batterie batterie in this.batteries)
            {
                total += batterie.Cout();
            }

            return total;
        }

        /// <summary>
        /// Ajoute un corps dans la liste de l'armée
        /// </summary>
        /// <param name="corps">Corps que l'on veut ajouter</param>
        public void AjouterCorps(Corps corps)
        {
            this.Corps.Add(corps);
        }

        /// <summary>
        /// Ajoute une division dans la liste de l'armée
        /// </summary>
        /// <param name="division">Division que l'on veut ajouter</param>
        public void AjouterDivision(Division division)
        {
            this.Divisions.Add(division);
        }

        /// <summary>
        /// Ajoute une brigade dans la liste de l'armée, s'il y en a moins de 2
        /// </summary>
        /// <param name="brigade"></param>
        public void AjouterBrigade(Brigade brigade)
        {
            if (this.brigades.Count < 2)
            {
                this.brigades.Add(brigade);
            }
        }

        /// <summary>
        /// Ajoute un régiment dans la liste de l'armée, s'il y en a moins de 2
        /// </summary>
        /// <param name="regiment">Regiment que l'on veut ajouter</param>
        public void AjouterRegiment(Regiment regiment)
        {
            if (this.regiments.Count < 2 )
            {
                if (regiment.estAjoutable() == true)
                {
                    this.regiments.Add(regiment);
                }                
            }
        }

        /// <summary>
        /// Ajoute une batterie d'artillerie à la liste de l'armée 
        /// </summary>
        /// <param name="batterie"></param>
        public void AjouterBatteries(Batterie batterie)
        {
            this.batteries.Add(batterie);
        }
        #endregion
    }
}
