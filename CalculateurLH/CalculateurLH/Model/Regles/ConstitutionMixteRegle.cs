using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Regles
{
    /// <summary>
    /// Classe qui gère la règle Constitution Mixte
    /// </summary>
    public class ConstitutionMixteRegle : IRegle
    {
        private string nom;
        private string description;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public ConstitutionMixteRegle()
        {
            this.nom = "Constitution mixte";
            this.description = "L’unité est constituée d’une ou plusieurs compagnies d’élite et de compagnies de combat. Selon la position des compagnies d’élite (carabiniers ou grenadiers), le bonus est différent :\r\n1) Elles sont disposées en dernière ligne : elles font bénéficier l’unité d’un bonus. Elles passent les tests de psychologie et de discipline suivant les caractéristiques des compagnies d’élite, le plus souvent de grenadiers ou carabiniers.\r\n2) Elles sont disposées au premier rang : ce sont elles qui frapperont selon leurs caractéristiques physiques.Lors d’une reformation, on choisit leur position dans l’unité. En revanche, elles prendront la discipline et psychologie des troupes de bases du bataillon.\r\nLes seules nations à pouvoir disposer leurs grenadiers au dernier rang sont les Français, les Anglais et les Portugais (convention historique pour les anglo-portugais).";
        }

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

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }
    }
}
