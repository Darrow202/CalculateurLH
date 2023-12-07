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
        private string nom;
        private List<Division> divisions;
        private List<Brigade> brigades;
        private List<Regiment> regiments;

        /// <summary>
        /// COnstructeur de la classe
        /// </summary>
        /// <param name="nom">Nom du corps d'armée</param>
        public Corps(string nom) 
        {
            this.nom = nom;
            this.divisions = new List<Division>();
            this.brigades = new List<Brigade>();
            this.regiments = new List<Regiment>();
        }

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

            return total;
        }
    }
}
