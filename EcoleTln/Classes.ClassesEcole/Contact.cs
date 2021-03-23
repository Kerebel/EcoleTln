using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Contact
    {
        protected int matricule;
        protected string nom;
        protected int anneeArrivee;

        

        public Contact(int matricule, string nom, int anneeArrivee)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.anneeArrivee = anneeArrivee;
        }
        protected int Matricule { get => matricule; }
        protected string Nom { get => nom; }
        protected int AnneeArrivee { get => anneeArrivee;}
    }
}
