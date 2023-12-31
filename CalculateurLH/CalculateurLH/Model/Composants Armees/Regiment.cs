﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateurLH.Model.Composants_Armees
{
    public class Regiment
    {
        #region --- Attributs ---
        private string nom;
        private string type;
        private List<IUnite> bataillons;
        private List<Batterie> batteries;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="nom">Nom du régiment</param>
        public Regiment(string nom)
        {
            this.nom = nom;
            this.bataillons = new List<IUnite>();
            this.batteries = new List<Batterie>();
        }
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Renvoie ou modifie le nom du régiment
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
        /// Renvoie ou modifie le type du régiment
        /// </summary>
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

        /// <summary>
        /// Renvoie ou modifie la liste des bataillons de l'unité
        /// </summary>
        public List<IUnite> Bataillons
        {
            get
            {
                return this.bataillons;
            }

            set
            {
                this.bataillons = value;
            }
        }

        /// <summary>
        /// Renvoie ou modifie l'artillerie régimentaire
        /// </summary>
        public List<Batterie> Batteries
        {
            get
            {
                return this.batteries;
            }

            set
            {
                this.batteries = value;
            }
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Renvoie le cout du régiment
        /// </summary>
        public int Cout()
        {
            int total = 0;

            foreach(IUnite bataillon in this.bataillons) 
            {
                total += bataillon.Cout;
            }

            foreach (Batterie batterie in batteries)
            {
                total += batterie.Cout();
            }

            return total;
        }

        /// <summary>
        /// Ajoute une batterie d'artillerie à la liste du régiment
        /// </summary>
        /// <param name="batterie">Batterie à ajouter</param>
        public void AjouterBatterie(Batterie batterie)
        {
            this.batteries.Add(batterie);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool estAjoutable()
        {
            bool res = false;

            return res;
        }
        #endregion
    }
}
