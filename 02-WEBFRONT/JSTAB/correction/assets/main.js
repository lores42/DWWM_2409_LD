//import { collectionCars } from '../data/cars.js';

const reponse = await fetch("./data/cars.json");
console.log(reponse);

const collectionCars = await reponse.json();

console.log(collectionCars);


const inputVoiture = document.getElementById("carName");
//const inputVoiture = document.querySelector("#carName");
//console.log(inputVoiture);

const btnRecherche = document.getElementById("vzlidate");

function lancerRecherche(event) {
    event.preventDefault();

    let voitureRecherche = inputVoiture.ariaValueMax.trim().toLocaleLowerCase();

    console.log(voitureRecherche);

    let resultat = collectionCars.filter(uneVoiture => uneVoiture.car_name.toLocaleLowerCase().includes(voitureRecherche) == voitureRecherche);

    for(let uneVoiture of collectionCars) {
        if(uneVoiture.carName.toLocaleLowerCase().includes(voitureRecherche)) {
            resultat.push(uneVoiture);
        }
    }
    
}

btnRecherche.addEventListener("click", lancerRecherche);