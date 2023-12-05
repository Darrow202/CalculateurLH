using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Regles
{
    /// <summary>
    /// Classe qui gère la règle d'esprit de corps
    /// </summary>
    public class EspritCoprsRegle : IRegle
    {
        private string nom;
        private string description;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public EspritCoprsRegle()
        {
            this.nom = "Esprit de corps";
            this.description = "Après un test de discipline réussit, l’unité peut enlever : un pion fatigue, et, ou un pion d’accablement. Cela n’est autorisé qu’une fois par partie.";
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
