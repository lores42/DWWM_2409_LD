const people = ['Mike Dev', 'John Makenzie', 'Byrôn Méssia']

const form = document.querySelector("form")
const inputFirstname = document.querySelector("#input-firstname")
const inputLastname = document.querySelector("#input-lastname")
const btnAdd = document.querySelector("#btn-add")
const formMessage = document.querySelector("#form-message")
const message = document.querySelector("#message")
const table = document.querySelector("table")
const tbody = document.querySelector("tbody")
const ul = document.querySelector("ul")

const affichage = () => {
    tbody.innerText = ""
    ul.innerText = ""
    if(people.length>0){
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

            const cleanedFirstname = firstname.normalize("NFD").replace(/[\u0300-\u036f]/g, "") 
            const cleanedLastname = lastname.normalize("NFD").replace(/[\u0300-\u036f]/g, "")
            
            tdEmail.innerText = `${cleanedFirstname.toLowerCase()}.${cleanedLastname.toLowerCase()}@exemple.com`
            tdSupprimer.innerHTML = `<a href="" id="${index}" class="btn-suppr">X</a>`
    
            tbody.append(tr)
            tr.append(tdNom, tdPrenom, tdEmail, tdSupprimer)
        })  
        const btnSupprArray = document.querySelectorAll(".btn-suppr")
        
        btnSupprArray.forEach(b => {
            b.addEventListener("click", (event) => {
                event.preventDefault()
                people.splice(b.id, 1)
                affichage()
            })
        })
    }
    else{
        table.innerText = ""
        message.innerText = "La liste est vide !"
    }
}

form.addEventListener("submit", (event) => {
    event.preventDefault()

    const reg = /[a-zA-Z-]{2,}/
    if(reg.test(inputFirstname.value.trim()) && reg.test(inputLastname.value.trim())){
        const firstname = String(inputFirstname.value.trim()).charAt(0).toUpperCase() + " " + String(inputFirstname.value.trim())
        const lastname = String(inputLastname.value.trim()).charAt(0).toUpperCase() + " " + String(inputLastname.value.trim())
        people.push(firstname + ' ' + lastname)
        affichage()
    }
})

affichage()


