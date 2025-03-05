const btntest = document.querySelector("#btntest");
//console.log(btntest);

const retirerclic = document.querySelector(".mini");
const compteur = document.querySelector("#taille");
compteur.value = 16;

btntest.addEventListener("click", function() {
  
  
  let tailleText = compteur.value;
  if (tailleText < 48) {
    tailleText++;
    document.querySelector("p").style.fontSize = tailleText + "px";
    compteur.value=tailleText;
  } else {
    tailleText = 16;
    compteur.value=tailleText;
    document.querySelector("p").style.fontSize = tailleText + "px";
    //compteur.value=tailleText;
  }
} );

retirerclic.addEventListener("click", function() {
  let tailleText = compteur.value;
  if (tailleText > 8) {
    tailleText--;
    document.querySelector("p").style.fontSize = tailleText + "px";
    compteur.value=tailleText;
  } else {
    tailleText = 16;
    document.querySelector("p").style.fontSize = tailleText + "px";
   compteur.value=tailleText;
  }
} );

compteur.addEventListener("blur", function() {
  let tailleText = compteur.value; 
  if(tailleText<=48 && tailleText>=8){
    document.querySelector("p").style.fontSize = tailleText + "px";
   // compteur.value=tailleText;
  } 
  
  else {
    
    tailleText = 16; 
    document.querySelector("p").style.fontSize = tailleText + "px";
    compteur.value= 16;
  }
})



