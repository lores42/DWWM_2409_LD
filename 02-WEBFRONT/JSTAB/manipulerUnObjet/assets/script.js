//var dateNow = new date();

const date_de_naissance = document.querySelector("#naissance")
const calculer = document.querySelector("#calculer");
const resultat = document.querySelector(".resultat");
const age = document.querySelector("#age");
/*
if (!dateNaissanceInput || !dateNaissanceInput.value) {
    resultatDiv.innerText = "Veuillez entrer une date de naissance.";
    return; // Arrêt de la fonction si la date est manquante
  }

resultat.innerText = "vous êtes née le " + resultat.value*/

//button = dateNow - dateNaissance;


calculer.addEventListener("click", ()=>{
  console.log(date_de_naissance.value);  
})


