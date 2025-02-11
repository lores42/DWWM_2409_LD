using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1botle
{
    public class Botle
    {
        // attributs
        private float capaciteEnLitre;
        private float contenuEnLitre;
        private bool estOuverte;
        private string typeDeContenu;

        // constructeurs 

        // constructeur par defaut 
        public Botle()
        {
            this.capaciteEnLitre = 1.5f;
            this.contenuEnLitre = 1f;
            this.estOuverte = true;
            this.typeDeContenu = "eau plate";
        }

        // constructeur classique
        public Botle(float capaciteEnLitre, float contenuEnLitre, bool estOuverte, string typeDeContenu)
        {
            this.capaciteEnLitre = capaciteEnLitre;
            this.contenuEnLitre = contenuEnLitre;
            this.estOuverte = estOuverte;
            this.typeDeContenu = typeDeContenu;
        }

        // constructeur hybride classique defaut 

        public Botle(float capaciteEnLitre, float contenuEnLitre, string typeDeContenu) : this(capaciteEnLitre, contenuEnLitre, true, typeDeContenu)
        {
        }

        // contructeur par clone
        public Botle(Botle bouteilleACopier)
        {
            this.capaciteEnLitre = bouteilleACopier.capaciteEnLitre;
            this.contenuEnLitre = bouteilleACopier.contenuEnLitre;
            this.estOuverte = bouteilleACopier.estOuverte;
            this.typeDeContenu = bouteilleACopier.typeDeContenu;
        }

       public bool EstOuverte()
        {
            if (!estOuverte)
            {
                estOuverte = true;               
            }
            return estOuverte;
        }
      
    }
}
