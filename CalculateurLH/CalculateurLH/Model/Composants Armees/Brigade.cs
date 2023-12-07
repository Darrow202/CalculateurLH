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
        /// <summary>
        /// Renvoie ou modifie le nom de la brigade
        /// </summary>
        public string Nom {  get; set; }

        /// <summary>
        /// Renvoie ou modifie la liste des régiments contenus dans la brigade
        /// </summary>
        public List<Regiment> Regiments { get; set; }

        /// <summary>
        /// Renvoie ou modifie le cout de la brigade
        /// </summary>
        public int Cout()
        {
            int total = 0;

            foreach(Regiment regiment in Regiments)
            {
                total += regiment.Cout();
            }

            return total;
        }
    }
}
