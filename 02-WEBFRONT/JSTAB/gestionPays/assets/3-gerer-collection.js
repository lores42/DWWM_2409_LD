import { getPays } from "../utils/getPays.js";

const tbody = document.querySelector("#mesPays");


const display = (monObj) => {
    const tr = tbody.insertRow()
    const tdCode = tr.insertCell()
    const tdName = tr.insertCell()

    tdCode.textContent = monObj.country_code;
    tdName.textContent = monObj.country_name;
}

const init = async () => {
    const listPays = await getPays();
    
    listPays.forEach((pays) => {
        display(pays)
    })
};

init();