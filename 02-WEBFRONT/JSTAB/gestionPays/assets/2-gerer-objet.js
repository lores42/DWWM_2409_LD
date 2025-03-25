import { ucFirst } from "../utils/stringUtil.js";
// Utiliser un objet littéral existant
const laFrance = {
    country_code: "FR",
    country_name: "France",
};

const listPays = [
    laFrance,
    {
        country_code: "GB",
        country_name: "Grande-Bretagne",
    }
];

let laBelgique = {}
const getBelgique = async () => {
    try {
        const response = await fetch("../data/belgique.json");
        if (!response.ok) {
            throw new Error("problème durant le chargement du fichier !");
        }
        laBelgique = await response.json()
        listPays.push(laBelgique)
    } catch (error) {
        console.log(error);
    }
};

const display = (monObj, index) => {
    const main = document.querySelector("main");

    const article = document.createElement("article");
    const p = document.createElement("p");
    
    p.innerText = `Pays ${++index} : ${monObj.country_name} (${monObj.country_code})`;
    
    article.append(p);
    main.append(article);
}

const init = async () => {
    await getBelgique();
    
    listPays.forEach((pays, i) => {
        display(pays, i)
    })
};

init();



const zeremi = "rEMIIIIIIII";

console.log(ucFirst('jhghjfjhfjhjhf'));

