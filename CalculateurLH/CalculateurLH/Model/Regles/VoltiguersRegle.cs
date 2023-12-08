using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Regles
{
    /// <summary>
    /// Classe qui gère la règle Voltigeurs
    /// </summary>
    public class VoltiguersRegle : IRegle
    {
        private string nom;
        private string description;

        /// <summary>
        /// COnstructeur de la classe
        /// </summary>
        public VoltiguersRegle()
        {
            this.nom = "Voltigeurs";
            this.description = "Les voltigeurs des bataillons peuvent être détachés du bataillon pour former un écran de tirailleurs. Ils suivront alors la règle « tirailleurs ». Les voltigeurs d'un même régiment peuvent aussi être regroupés pour former un bataillon de voltigeurs. Ce nouveau bataillon suivra les règles « tirailleurs » et « infanterie légère ». \r\n- Ecran de tirailleur : les compagnies suivant cette règle peuvent être détachées du bataillon afin de constituer une avant-garde du bataillon. Les figurines doivent être déployées à 6ps ou moins du bataillon. Les voltigeurs détachés devront recevoir des ordres spécifiques mais seront activés en même temps que l’unité « mère ». \r\nSi l’écran de voltigeurs est chargé, les voltigeurs devront se réfugier dans le bataillon « mère » (au dernier rang). L'unité les ayant chargés ratera alors sa charge, à moins que son mouvement ne l'amène au contact du bataillon « mère ». \r\nSi l'ordre \"charge\" est donné à leur bataillon, les tirailleurs s'écartent et rejoignent l'unité et se mettent à l'arrière. Ils ne participeront pas au combat et ne donneront pas de bonus de rangs pendant ce tour. Si l'ordre \"charge\" est donné à leur bataillon et qu'il rate sa charge, les tirailleurs s'écartent et rejoignent l'unité (ils se mettent à l'arrière). L'unité sera en désordre suite à la charge ratée. \r\nSi les voltigeurs sont devant, le bataillon « mère » ne pourra pas recevoir d’ordre tir.";
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
