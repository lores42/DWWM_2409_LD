const people = ['Mike Dev', 'John Makenzie', 'Léa Grande']

const form = document.querySelector("form")
const inputFirstname = document.querySelector("#input-firstname")
const inputLastname = document.querySelector("#input-lastname")
const btnAdd = document.querySelector("#btn-add")
const message = document.querySelector("#message")
const table = document.querySelector("table")
const tbody = document.querySelector("tbody")
const ul = document.querySelector("ul")

const affichage = () => {
    people.forEach((p, index) => {
        const li = document.createElement("li")
        li.innerText = p
        ul.append(li)

        const tr = document.createElement("tr")
        const tdNom = document.createElement("td")
        const tdPrenom = document.createElement("td")
        const tdEmail = document.createElement("td")
        const tdSupprimer = document.createElement("td")

        const firstname = p.split(" ")[0]
        const lastname = p.split(" ")[1]

        tdNom.innerText = lastname
        tdPrenom.innerText = firstname
        tdEmail.innerText = `${firstname}.${lastname}@exemple.com`
        tdSupprimer.innerHTML = `<a href="" id="${index}" class="btn-suppr">X</a>`

        tbody.append(tr)
        tr.append(tdNom, tdPrenom, tdEmail, tdSupprimer)
    })  
}

const btnSupprArray = document.querySelectorAll(".btn-suppr")

btnSupprArray.forEach(b => {
    b.addEventListener("click", (event) => {
        event.preventDefault()
        people.splice(b.id, 1)
        affichage()
    })
})

affichage()


