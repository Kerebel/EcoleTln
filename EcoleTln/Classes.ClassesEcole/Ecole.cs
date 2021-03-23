using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ClassesEcole
{
    class Ecole
    {
        private string nom;
        private int anneeCreation;
        private Dictionary<int ,Contact> contacts  = new Dictionary<int,Contact>();

        public Ecole(string nom, int anneeCreation, Dictionary<int, Contact> contacts)
        {
            this.nom = nom;
            this.anneeCreation = anneeCreation;
            this.Contacts = contacts;
        }

        public string AfficheTous()
        {
            
        }
        public double ancienneteMoyenne
        public string Nom { get => nom; }
        public int AnneeCreation { get => anneeCreation; }
        internal Dictionary<int, Contact> Contacts { get => contacts;  private set => contacts = value; }
    }
}
