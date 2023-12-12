using CalculateurLH.Model;
using CalculateurLH.Model.Regles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Factions.France.Infanterie
{
    /// <summary>
    /// Classe qui gère un bataillon d'infanterie francaise
    /// </summary>
    public class InfanterieLigneFr : IUnite
    {
        #region --- Attributs ---
        private string type;
        private string[] typeCompagnies;
        private int nbFigurinesCompagnies;
        private int[] nbCompagnies;
        private int[] instruction;
        private int[] discipline;
        private int[] physique;
        private int[] psycologie;
        private string[] mouvement;
        private string classe;
        private List<IRegle> regles;
        private int cout;
        #endregion

        #region --- Constructeur ---

        /// <summary>
        /// Constructeur de la classe, qui regarde la classe du bataillon et qui ajoute les stats en fonction
        /// </summary>
        /// <param name="classe">Classe du bataillon</param>
        public InfanterieLigneFr(string classe) 
        {
            this.type = "Infanterie de ligne";
            this.typeCompagnies = new string[] { "Fusilliers", "Grenadiers", "Voltiguers" };
            this.nbFigurinesCompagnies = 4;
            this.nbCompagnies = new int[] { 4, 1, 1 };
            this.classe = classe;

            this.regles = new List<IRegle>();
            regles.Add(new ConstitutionMixteRegle());
            regles.Add(new GrenadiersRegle());
            regles.Add(new VoltiguersRegle());

            if (classe == "levee")
            {
                this.instruction = new int[] { 2, 3, 3 };
                this.discipline = new int[] { 6, 7, 7 };
                this.physique = new int[] { 3, 4, 3 };
                this.psycologie = new int[] { 5, 6, 6 };
                this.mouvement = new string[] { "3", "3", "3(4)" };
                this.cout = 80;
            }

            else if (classe == "conscrit")
            {
                this.instruction = new int[] { 3, 4, 4 };
                this.discipline = new int[] { 7, 8, 8 };
                this.physique = new int[] { 3, 4, 3 };
                this.psycologie = new int[] { 6, 7, 7 };
                this.mouvement = new string[] { "4", "4", "4(5)" };
                this.cout = 112;
            }

            else
            {
                this.instruction = new int[] { 4, 5, 5 };
                this.discipline = new int[] { 8, 8, 8 };
                this.physique = new int[] { 4, 5, 4 };
                this.psycologie = new int[] { 7, 8, 8 };
                this.mouvement = new string[] { "4", "4", "4(5)" };
                this.cout = 144;
            }
        }

        #endregion

        #region --- Propriétés ---

        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public string[] TypeCompagnies
        {
            get
            {
                return this.typeCompagnies;
            }

            set
            {
                this.typeCompagnies = value;
            }
        }

        public int NbFigurinesCompagnies
        {
            get
            {
                return this.nbFigurinesCompagnies;
            }

            set
            {
                this.nbFigurinesCompagnies = value;
            }
        }

        public int[] NbCompagnies
        {
            get
            {
                return this.nbCompagnies;
            }

            set
            {
                this.nbCompagnies = value;
            }
        }

        public int[] Instruction
        {
            get
            {
                return this.instruction;
            }

            set
            {
                this.instruction = value;
            }
        }

        public int[] Discipline
        {
            get
            {
                return this.discipline;
            }

            set
            {
                this.discipline = value;
            }
        }

        public int[] Physique
        {
            get
            {
                return this.physique;
            }

            set
            {
                this.physique = value;
            }
        }

        public int[] Psycologie
        {
            get
            {
                return this.psycologie;
            }

            set
            {
                this.psycologie = value;
            }
        }

        public string[] Mouvement
        {
            get
            {
                return this.mouvement;
            }

            set
            {
                this.mouvement = value;
            }
        }

        public string Classe
        {
            get
            {
                return this.classe;
            }

            set
            {
                this.classe = value;
            }
        }

        public List<IRegle> Regles
        {
            get
            {
                return this.regles;
            }

            set
            {
                this.regles = value;
            }
        }

        public int Cout
        {
            get
            {
                return this.cout;
            }

            set
            {
                this.cout = value;
            }
        }
        #endregion


    }
}
