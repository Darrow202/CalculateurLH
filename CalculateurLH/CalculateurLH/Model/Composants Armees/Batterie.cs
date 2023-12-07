using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Composants_Armees
{
    /// <summary>
    /// Classe qui gère les batteries d'artillerie
    /// </summary>
    public class Batterie
    {
        private string nom;
        private List<ICanon> canons;
        private List<ICanon> trains;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="nom"></param>
        public Batterie(string nom)
        {
            this.nom = nom;
            this.canons = new List<ICanon>();
            this.trains = new List<ICanon>();
        }

        /// <summary>
        /// Renvoie ou modifie le nom de la batterie
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
        /// Renvoie ou modifie la liste des canons de la batterie
        /// </summary>
        public List<ICanon> Canons
        {
            get
            {
                return this.canons;
            }

            set
            {
                this.canons = value;
            }
        }

        /// <summary>
        /// Renvoie ou modifie la liste des trains de la batterie
        /// </summary>
        public List<ICanon> Trains
        {
            get
            {
                return this.trains;
            }

            set
            {
                this.trains = value;
            }
        }


        /// <summary>
        /// Renvoie le cout de la batterie en le calculant avec le prix de ses composants
        /// </summary>
        /// <returns>Le prix de la batterie</returns>
        public int Cout()
        {
            int total = 0;

            foreach (ICanon canon in this.canons)
            {
                total += canon.Cout;
            }

            foreach (ICanon canon in this.trains)
            {
                total += canon.Cout;
            }

            return total;
        }
    }
}
