using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilisateurs
{
    public class Utilisateurs
    {
       // private Guid id;
        private string nom;

        private string prenom;

        private System.DateTime dateDeNaissance;

        private string? metier;

        private string? couleurPreferee;

        public Utilisateurs(string _nomPrenom, string _dateDeNaissance)
        {
            string[] nomPrenomSepare = _nomPrenom.Split(" ");
            this.nom = nomPrenomSepare[0];
            this.prenom = nomPrenomSepare[1];

            if (DateTime.TryParse(_dateDeNaissance, out dateDeNaissance))
            {
                throw new ArgumentException("Date de naissance non valide !");
            }

            if(dateDeNaissance > DateTime.Now)
            {
                throw new ArgumentException("La date doit être dans le passé!");
            }

            //
        }

        public Utilisateurs() 
        {
            
        }

        public void SetMetier(string _valeur)
        {
            this.metier = _valeur;
        }

        public int GetAge()
        {
            TimeSpan intervalle = DateTime.UtcNow - dateDeNaissance;
            int age = (int)(intervalle.Days / 365.25);
            return age;
        }

        public bool IsMajeur()
        {
            return this.GetAge() >18;
        }

        public string GetCouleurOuMetier()
        {
            if(this.metier == null && couleurPreferee == null)
            {
                throw new Exception("Le métier ou la couleur préférée doivent être valide. ");
            }
            if (this.IsMajeur())
            {
                return this.metier; 
            }

            else
            {
                return this.couleurPreferee;
            }
        }

        public string GetDateDeNaissance()
        {
            return ""; 
        }

        public  string GetNomComplet()
        {
            return nom + " " + prenom;
        }
    }
}