/*var dateNow = new Date();
let dateNaissance = document.querySelector("#naissance");

const btn = document.querySelector("button");
const resultat = document.querySelector(".resultat");
const age = document.querySelector(".age");
 
btn.addEventListener("click", function (event) {
    event.preventDefault();
    let newDate = new Date(dateNaissance.value)
if(newDate > dateNow){
    resultat.innerText = "votre date n'est pas valide !!";
    console.log(newDate.toISOString());
    
}
else{
    resultat.innerText = `Vous etes née le  ${dateNaissance.value} à ${Time.value}`;

})*/

/*
var dateNow = new Date();
let dateNaissance = document.querySelector("#naissance");
let signeAstro = document.querySelector(".signe");

const btn = document.querySelector("button");
const resultat = document.querySelector(".resultat");
const age = document.querySelector(".age");

btn.addEventListener("click", function (event) {
    event.preventDefault();
    
    resultat.style.borderBottom = "1px solid black";
    
    if (!dateNaissance.value) {
        resultat.innerText = "Veuillez entrer une date de naissance";
    }
    else {
        let newDate = new Date(dateNaissance.value);
        
        if (newDate > dateNow) {
            resultat.innerText = "Votre date de naissance n'est pas valide (date future) !";
            console.log(newDate.toISOString());
        }
        else
        {
            const dateFormatee = `${String(newDate.getDate()).padStart(2, "0")}/${String(newDate.getMonth()+1).padStart(2, "0")}/${newDate.getFullYear()}`;
            const heureFormate = `${String(newDate.getHours()).padStart(2, "0")}:${String(newDate.getMinutes()).padStart(2, "0")}`;
            resultat.innerText = `Vous êtes né(e) le ${dateFormatee } à ${heureFormate}`;
            
           
            let ageReel = dateNow.getFullYear() - newDate.getFullYear();
            let moisDiff = dateNow.getMonth() - newDate.getMonth();
            
            if (moisDiff < 0 || (moisDiff === 0 && dateNow.getDate() < newDate.getDate())) {
                ageDiff--;
            }
            const s = ageReel > 1 ? 's' : ''
            age.innerText = `Vous avez ${ageReel} an${s}`;
        }
    }
    resultat.style.borderBottom = "1px solid black";
    
  //signeAstro.innerText();


});
 function innerText() {
        if ((dateNaissance.getMonth() === 1 && dateNaissance.getDate() >= 20) || 
        (dateNaissance.getMonth() === 2 && dateNaissance.getDate() <= 18)) {
        signeAstro.innerHTML = "Vous êtes Verseau";
        console.log(signeAstro);
            
}
};
*/

var dateNow = new Date();
let dateNaissance = document.querySelector("#naissance");
const signeAstro = document.querySelector(".signe");
const imageAstro = document.querySelector(".image")

const btn = document.querySelector("button");
const resultat = document.querySelector(".resultat");
const age = document.querySelector(".age");

btn.addEventListener("click", function (event) {
    event.preventDefault();
    
    resultat.style.borderBottom = "1px solid black";
    
    if (!dateNaissance.value) {
        resultat.innerText = "Veuillez entrer une date de naissance";
    }
    else {
        let newDate = new Date(dateNaissance.value);
        
        if (newDate > dateNow) {
            resultat.innerText = "Votre date de naissance n'est pas valide (date future) !";
            console.log(newDate.toISOString());
        }
        else {
            const dateFormatee = `${String(newDate.getDate()).padStart(2, "0")}/${String(newDate.getMonth()+1).padStart(2, "0")}/${newDate.getFullYear()}`;
            const heureFormate = `${String(newDate.getHours()).padStart(2, "0")}:${String(newDate.getMinutes()).padStart(2, "0")}`;
            resultat.innerText = `Vous êtes né(e) le ${dateFormatee} à ${heureFormate}`;
            
            let ageReel = dateNow.getFullYear() - newDate.getFullYear();
            let moisDiff = dateNow.getMonth() - newDate.getMonth();
            
            if (moisDiff < 0 || (moisDiff === 0 && dateNow.getDate() < newDate.getDate())) {
                ageReel--; 
            }
            const s = ageReel > 1 ? 's' : '';
            age.innerText = `Vous avez ${ageReel} an${s}`;
            
            
            indiquerSigneAstro(newDate); 
        }
    }
    
    resultat.style.borderBottom = "1px solid black";
});


function indiquerSigneAstro(date) {
    const mois = date.getMonth() + 1;
    const jour = date.getDate();
    
    if ((mois === 1 && jour >= 20) || (mois === 2 && jour <= 18)) {
        signeAstro.innerHTML = "Vous êtes Verseau";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Verseau.png'>"
    }
    
    else if ((mois === 2 && jour >= 19) || (mois === 3 && jour <= 20)) {
        signeAstro.innerHTML = "Vous êtes Poissons";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Poissons.png'>"
    }
    
    else if ((mois === 3 && jour >= 21) || (mois === 4 && jour <= 19)) {
        signeAstro.innerHTML = "Vous êtes Bélier";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Belier.png'>"
    }
    
    else if ((mois === 4 && jour >= 20) || (mois === 5 && jour <= 20)) {
        signeAstro.innerHTML = "Vous êtes Taureau";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Taureau.png'>"
    }
    
    else if ((mois === 5 && jour >= 21) || (mois === 6 && jour <= 20)) {
        signeAstro.innerHTML = "Vous êtes Gémaeaux";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Gémaeaux.png'>"
    }
    
    else if ((mois === 6 && jour >= 21) || (mois === 7 && jour <= 22)) {
        signeAstro.innerHTML = "Vous êtes Cancer";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Cancer.png'>"
    }
    
    else if ((mois === 7 && jour >= 23) || (mois === 8 && jour <= 22)) {
        signeAstro.innerHTML = "Vous êtes Lion";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Lion.png'>"
    }
    
    else if ((mois === 8 && jour >= 23) || (mois === 9 && jour <= 22)) {
        signeAstro.innerHTML = "Vous êtes Vierge";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Vierge.png'>"
    }
    
    else if ((mois === 9 && jour >= 23) || (mois === 10 && jour <= 22)) {
        signeAstro.innerHTML = "Vous êtes Balance";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Balance.png'>"
    }
    
    else if ((mois === 10 && jour >= 23) || (mois === 11 && jour <= 21)) {
        signeAstro.innerHTML = "Vous êtes Scorpion";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Scorpion.png'>"
    }
    
    else if ((mois === 11 && jour >= 22) || (mois === 12 && jour <= 21)) {
        signeAstro.innerHTML = "Vous êtes Sagitaire";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Sagitaire.png'>"
    }
    
    else if ((mois === 12 && jour >= 22) || (mois === 1 && jour <= 19)) {
        signeAstro.innerHTML = "Vous êtes Capricorne";
        imageAstro.innerHTML = "<img src='signeDuZodiaque/Capricorne.png'>"
    }
        
    else {
        signeAstro.innerHTML = "Signe astrologique non déterminé";
    }
    console.log(signeAstro);
}