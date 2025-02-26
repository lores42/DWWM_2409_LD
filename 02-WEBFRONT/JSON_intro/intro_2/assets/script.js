
const btntest=document.querySelector("#btntest");
console.log(btntest);


const retirerclic = document.querySelector(".min");
const compteur = document.querySelector("taille");
 .addEventListener("click",function () {
 let tailleDep = parseInt(compteur.textContent);
 if (tailleDep<48) {
     tailleDep++;
    
     compteur.textContent = tailleDep;
     document.querySelector("p").style.fontSize = tailleDep+"px";
 }

else{
     compteur.textContent = 16;
     document.querySelector("p").style.fontSize = 16+"px";
 }
 }

   
 )