using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Regles
{
    public class CavalerieLegereRegle : IRegle
    {
        private string nom;
        private string description;

        public CavalerieLegereRegle()
        {
            this.nom = "Cavalerie légère";
            this.description = "Elle peut détacher un escadron, et suivra la règle écran de tirailleur (fourrageur !), comme une unité de tirailleurs Français.";
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
