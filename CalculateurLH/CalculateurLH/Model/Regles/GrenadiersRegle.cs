using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Regles
{
    /// <summary>
    /// CLasse qui gère la règle Grenadiers
    /// </summary>
    public class GrenadiersRegle : IRegle
    {
        private string nom;
        private string description;

        public GrenadiersRegle()
        {
            this.nom = "Grenadiers";
            this.description = "Les grenadiers « poussent » les hommes de leur bataillon au combat. L'ensemble du bataillon bénéficie de leur expérience au combat. Si la compagnie de grenadier est sur le rang arrière du bataillon : le bataillon bénéficie de la Discipline et Psychologie de ces derniers, ceci tant que la compagnie comprend au moins 2 Grenadiers.";
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
