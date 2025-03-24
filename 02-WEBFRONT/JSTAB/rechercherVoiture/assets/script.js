// assignation de l'élément input#carName à la const inputVoiture
const inputVoiture = document.querySelector("#carName");
// assignation de l'élément button#validate à la const btn
const btn = document.querySelector("#validate");
// assignation de l'élement div#result a la const resultat
const resultat = document.querySelector("#result");

//création de la variable voiture
let listeVoitures = [];

//création du fetch pour récupérer le fichier-JSON
async function afficherVoiture() {
  const reponse = await fetch(
    "https://raw.githubusercontent.com/ARFP/DWWM_2409/refs/heads/develop/02%20-%20webfront/JS/exo-js-cars/data/cars.json"
  );
  listeVoitures = await reponse.json();
}

await afficherVoiture();

//création de l'événement recherche et comparaison de la avaleur soumise au fichier JSON
btn.addEventListener("click", function (event) {
// empeche la page de se rechareger
  event.preventDefault();

  resultat.innerText = "";

  let maVoiture = inputVoiture.value.toLowerCase();

  if (maVoiture != "") {
    listeVoitures.forEach((uneVoiture) => {
      let nomVoiture = uneVoiture.car_name.toLowerCase();
      if (nomVoiture.includes(maVoiture)) {
        const div = document.createElement("div");
        div.className = "card";

        const spanId = document.createElement("span");
        const spanNom = document.createElement("span");
        const spanAnnee = document.createElement("span");
        const spanPays = document.createElement("span");

        spanId.innerText = uneVoiture.car_id;
        spanNom.innerText = uneVoiture.car_name;
        spanAnnee.innerText = uneVoiture.car_model;
        spanPays.innerText = uneVoiture.car_origin;

        div.append(spanId, spanNom, spanAnnee, spanPays);
        resultat.append(div);
      }
    });
  }
});
