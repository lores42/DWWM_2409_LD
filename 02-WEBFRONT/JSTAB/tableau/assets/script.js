document.body.style.backgroundColor = "#536B78";
document.body.style.color = "#ACCBE1";
document.body.style.fontFamily = "Verdana";
const people = ["Mike Dev", "John Makenzie", "Kendric Lamar"];

document
  .querySelector(".cadre")
  .setAttribute("style", "border: 2px solid #ACCBE1; padding : 20px");
people.push("Vybz kartel");
people.unshift("Byron Messia");
people.splice(2, 1, "Tia London");

for (let i = 0; i < people.length; i++) {
  let myLi = document.createElement("li");
  myLi.textContent = people[i];
  document.querySelector("#liste").appendChild(myLi);
}

document.querySelector("#liste").setAttribute("style", "list-style:none");
// j essaye de récuperer les éllément du tableau pour composer mon adresse mail
///let infoMail = document.querySelector(".tableau");

//nfoMail ("nom"+"."+"prenom"+"@example.com");

//création de tableau
const myTable = document.querySelector("#table_data");
myTable.setAttribute("cellspacing", "0");

//création de la première ligne du tableau
const myThead = myTable.createTHead();
const myTitleRow = myThead.insertRow();

//
function createTitleCell(text, row) {
  let myCell = document.createElement("th");

  myCell.setAttribute(
    "style",
    "border: 1px solid  #ACCBE1 ; padding: 10px; background-color: #637081"
  );
  myCell.textContent = text;
  //sert à ratacher myCell a la ligne
  row.appendChild(myCell);
}
createTitleCell("nom", myTitleRow);
createTitleCell("prenom", myTitleRow);
createTitleCell("email", myTitleRow);
createTitleCell("Suprimer", myTitleRow);

function createCell(text, row) {
  let myTableIn = document.createElement("td");

  myTableIn.setAttribute(
    "style",
    "border: 1px solid  #ACCBE1 ; padding: 10px; background-color: #637081"
  );
  myTableIn.textContent = text;
  row.appendChild(myTableIn);
}

//crée ligne d élément de mon tableau
const myTBody = myTable.createTBody();

people.forEach((Element) => {
  //recupère les éllément du tableau selon leur indice
  let prenom = Element.split(" ")[0];
  let nom = Element.split(" ")[1];
  let email = `${prenom.toLowerCase()}.${nom.toLowerCase()}@exemple.com`;
  let Suprimer = "X";

  const myRow = myTBody.insertRow();

  //myTBody.insertRow();
  createCell(nom, myRow);
  createCell(prenom, myRow);
  createCell(email, myRow);
  createCell(Suprimer, myRow);
});
