using System;
using System.ComponentModel.Design;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        // attributs
        private float capaciteEnLitre;
        private float contenuEnLitre;
        private bool estOuverte;
        private string typeDeContenu;

        // constructeurs 

        // constructeur par defaut 
        public Bouteille()
        {
            this.capaciteEnLitre = 1.5f;
            this.contenuEnLitre = 1f;
            this.estOuverte = true;
            this.typeDeContenu = "eau plate";
        }

        // constructeur classique
        public Bouteille(float capaciteEnLitre, float contenuEnLitre, bool estOuverte, string typeDeContenu)
        {
            this.capaciteEnLitre = capaciteEnLitre;
            this.contenuEnLitre = contenuEnLitre;
            this.estOuverte = estOuverte;
            this.typeDeContenu = typeDeContenu;
        }

        // constructeur hybride classique defaut 

        public Bouteille(float capaciteEnLitre, float contenuEnLitre, string typeDeContenu) : this(capaciteEnLitre, contenuEnLitre, true, typeDeContenu)
        {
        }

        // contructeur par clone
        public Bouteille(Bouteille bouteilleACopier)
        {
            this.capaciteEnLitre = bouteilleACopier.capaciteEnLitre;
            this.contenuEnLitre = bouteilleACopier.contenuEnLitre;
            this.estOuverte = bouteilleACopier.estOuverte;
            this.typeDeContenu = bouteilleACopier.typeDeContenu;
        }

        public bool ouvrir()
        {
            if (!estOuverte)
            {
                estOuverte = true;
                return true;
            }
            return false;
        }

        public bool fermer()
        {
            if (estOuverte)
            {
                estOuverte = false;
                return true;
            }
            return false;
        }
         public bool remplire()
        {
            if ((estOuverte == true) && (capaciteEnLitre > contenuEnLitre))
            {
                return true;
            }
            else if

            
        }
    }
}
