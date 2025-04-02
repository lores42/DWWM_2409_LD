export class Pays {

    constructor(codePays, nomPays) {

        if(!codePays || !nomPays) {
            throw new Error("Vous devez renseigner les deux champs !");
        }
        else {
            if(!/^[a-zA-Z]{2}$/.test(codePays)) {
                throw new Error("Le code pays doit contenir exactement deux lettres non accentuées !");    
            }
    
            if(!/^[a-zA-Z]{4,}$/.test(nomPays)) {
                throw new Error("Le nom du pays doit contenir au moins quatre lettres non accentuées !");    
            }
        }

        this.country_code = codePays.toUpperCase()
        this.country_name = nomPays.charAt(0).toUpperCase()+nomPays.slice(1).toLowerCase()
    }
}