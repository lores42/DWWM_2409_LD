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


var dateNow = new Date();
let dateNaissance = document.querySelector("#naissance");

const btn = document.querySelector("button");
const resultat = document.querySelector(".resultat");
const age = document.querySelector(".age");

btn.addEventListener("click", function (event) {
    event.preventDefault();
    
    resultat.style.border-bottom 1px solid black;
    if (!dateNaissance.value) {
        resultat.innerText = "Veuillez entrer une date de naissance";
        
    }

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
        
        age.innerText = `Vous avez ${ageReel} ans`;
    }
});