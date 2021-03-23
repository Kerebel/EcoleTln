using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Personnel : Contact

    {
        private string nomLaboratoire;
        private double salaire;

        public Personnel(int matricule, string nom, int anneeArrivee, string nomLaboratoire, double salaire) : base(matricule, nom, anneeArrivee)
        {
            this.nomLaboratoire = nomLaboratoire;
            this.salaire = salaire;
        }
        protected string NomLaboratoire { get => nomLaboratoire; }
        protected double Salaire { get => salaire;}
    }
}
