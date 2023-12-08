using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Composants_Armees
{
    /// <summary>
    /// Classe qui permet de créer toutes les unités
    /// </summary>
    public class FabriqueUnite
    {
        private Dictionary<string, ICreateUnite> constructeurs;
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.
        private static FabriqueUnite instance;
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.

        /// <summary>
        /// Renvoie l'instance de la fabrique et la crée si elle n'existe pas
        /// </summary>
        public static FabriqueUnite Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FabriqueUnite();
                }

                return instance;
            }
        }

        private FabriqueUnite()
        {
            this.constructeurs = new Dictionary<string, ICreateUnite>();
        }

        /// <summary>
        /// Renvoie la liste des unités que la fabrique peut créer
        /// </summary>
        public string[] Unites
        {
            get
            {
                return Instance.constructeurs.Keys.ToArray();
            }
        }

        /// <summary>
        /// Permet de créer une unité
        /// </summary>
        /// <param name="nom">Nom de l'unité que l'on veut créer</param>
        /// <returns>L'unité créée</returns>
        public IUnite Create(string nom)
        {
            return Instance.constructeurs[nom].CreateUnite();
        }

        /// <summary>
        /// Permet d'enregistrer une unité dans la liste créable
        /// </summary>
        /// <param name="nom">Nom de l'unité à créer</param>
        /// <param name="constructeur">Constructeur pour créer l'unité</param>
        public void Register(string nom,  ICreateUnite constructeur)
        {
            Instance.constructeurs[nom] = constructeur;
        }
    }
}
