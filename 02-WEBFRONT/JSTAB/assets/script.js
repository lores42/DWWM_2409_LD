const btntest = document.querySelector("#btntest");
//console.log(btntest);

const retirerclic = document.querySelector(".mini");
const compteur = document.querySelector("taille");

btntest.addEventListener("click", function() {
  let tailleText = parseInt(document.querySelector("span").textContent);
  if (tailleText < 48) {
    tailleText++;
    document.querySelector("p").style.fontSize = tailleText + "px";
    document.querySelector("span").textContent = tailleText;
  } else {
    tailleText = 16;
    document.querySelector("p").style.fontSize = tailleText + "px";
    document.querySelector("span").textContent = tailleText;
  }
} );

retirerclic.addEventListener("click", function() {
    let tailleText = parseInt(document.querySelector("span").textContent);
  if (tailleText > 8) {
    tailleText--;
    document.querySelector("p").style.fontSize = tailleText + "px";
    document.querySelector("span").textContent = tailleText;
  } else {
    tailleText = 16;
    document.querySelector("p").style.fontSize = tailleText + "px";
    document.querySelector("span").textContent = tailleText;
  }
} );



