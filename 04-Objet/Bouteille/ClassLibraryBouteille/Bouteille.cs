using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBouteille
{
    public class Bouteille
    {
        // attributs
        private float contenanceEnLitre;
        private float contenuEnLitre;
        private bool estOuverte;

        // constructeurs

        // construteur par defaut
        public Bouteille()
        {
            this.contenanceEnLitre = 1;
            this.contenuEnLitre = 1;
            this.estOuverte = false;
        }

        // constructeur classique
        public Bouteille(float contenanceEnLitre, float contenuEnLitre, bool estOuverte)
        {
            this.contenanceEnLitre = contenanceEnLitre;
            this.contenuEnLitre = contenuEnLitre;
            this.estOuverte = estOuverte;
        }

        // constructeur hybride classique defaut
        public Bouteille(float contenanceEnLitre, float contenuEnLitre) : this(contenanceEnLitre, contenuEnLitre, false)
        {
        }

        // construteur par clonage
        public Bouteille(Bouteille bouteilleACopier)
        {
            this.contenanceEnLitre = bouteilleACopier.contenanceEnLitre;
            this.contenuEnLitre = bouteilleACopier.contenuEnLitre;
            this.estOuverte = bouteilleACopier.estOuverte;

        }

        public bool Vider()
        {
            if (contenuEnLitre > 0 && estOuverte == true)
            {
                contenuEnLitre = 0;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Remplir()
        {
            if (estOuverte == true && contenuEnLitre < contenanceEnLitre)
            {
                contenuEnLitre = contenanceEnLitre;
                return true;
            }
            return false;
        }
        public bool Ouvrir()
        {
            if (!estOuverte)
            {
                estOuverte = true;
                return true;
            }
            return false;
        }
        public bool Fermer()
        {
            if (estOuverte)
            {
                estOuverte = false;
                return true;
            }
            return false;
        }
    }

}