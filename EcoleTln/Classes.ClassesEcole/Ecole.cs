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
            string cumul = "";
            foreach(Contact contact in contacts.Values)
            {
                cumul += contact.ToString();
                
            }
            return cumul;
        }
        public double AncienneteMoyenne()
        {
            double anneeAnciennete = 0;
            foreach (Contact contact in contacts.Values)
            {
                anneeAnciennete += (DateTime.Now.Year - contact.AnneeArrivee);
            }
            return anneeAnciennete / contacts.Count;
        }
        public bool EstEtudiant(Contact contact)
        {
            return contact is Etudiant;
        }
        public int NbContacts()
        {
            return contacts.Count;
        }
        public double MoyenneEtudiantRegulier()
        {
            double somme = 0;
            int cpt = 0;
            foreach (Contact contact in contacts.Values)
            {
                if (contact is EtudiantRegulier unEtudiantRegulier )
                {
                    somme += unEtudiantRegulier.NoteMoyenne;
                    cpt += 1;
                }
                
            }
            return somme / cpt;
        }
        public void AjouterContact(Contact contact)
        {
            if (!ExisteContact(contact))
            {
                contacts.Add(contact.Matricule,contact);
            }
        }
        public void AjouterContact(Dictionary<int, Contact> nouvContacts)
        {
            foreach (Contact contact in nouvContacts.Values)
            {
                this.AjouterContact(contact);
            }
        }
        public int NbEtudiants()
        {
            int cpt = 0;
            foreach (Contact etudiant in contacts.Values)
            {
                if (etudiant is Etudiant)
                {
                    cpt += 1;
                }
            }
            return cpt;
        }
        public bool ExisteContact(Contact contact)
        {
            return contacts.ContainsKey(contact.Matricule);
        }
        public bool ExisteContact(int matricule)
        {
            return contacts.ContainsKey(matricule);
        }
        public string Nom { get => nom; }
        public int AnneeCreation { get => anneeCreation; }
        internal Dictionary<int, Contact> Contacts { get => contacts;  private set => contacts = value; }
    }
}
