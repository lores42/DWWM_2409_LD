import { Pays } from "./Pays.js";

const inputCodePays = document.querySelector("#codePays");
const inputNomPays = document.querySelector("#nomPays");
const btn = document.querySelector("#validate");
const titre = document.querySelector("#titre");
const result = document.querySelector("#result");

const errorCodePays = document.querySelector("#error-code-pays");
const errorNomPays = document.querySelector("#error-nom-pays");


let nouveauPays = {};

titre.textContent = "Ajouter un pays";

btn.addEventListener("click", (event) => {
    event.preventDefault();
    result.textContent = "";
    errorCodePays.textContent = "";
    errorNomPays.textContent = "";

    try {
        nouveauPays = new Pays(inputCodePays.value, inputNomPays.value)
        
    } catch (error) {
        const p = document.createElement("p");
        p.textContent = error;
        result.append(p);
        
    }

    console.log(nouveauPays)


    if (inputCodePays.value && inputNomPays.value) {
        if (/^[a-zA-Z]{2}$/.test(inputCodePays.value)) {
            nouveauPays.country_code = inputCodePays.value.toUpperCase();
        } else {
            const p = document.createElement("p");
            p.textContent =
                "Le code pays doit contenir exactement deux lettres non accentuées !";
            errorCodePays.append(p);
        }

        if (/^[a-zA-Z]{4,}$/.test(inputNomPays.value)) {
            nouveauPays.country_ = inputNomPays.value.charAt(0).toUpperCase()+inputNomPays.value.slice(1).toLowerCase();
        } else {
            const p = document.createElement("p");
            p.textContent =
                "Le nom du pays doit contenir au minimum quatre lettres non accentuées !";
            errorNomPays.append(p);
        }
        console.log(nouveauPays);
    } else {
        const p = document.createElement("p");
        p.textContent = "Vous devez renseigner les deux champs !";
        result.append(p);
    }
        
});
