const plateau = document.querySelector(".plateau");

const joueur1 = "red";
const joueur2 = "yellow";
let joueurActuel = joueur1

for (let x = 0; x < 6; x++) {
    for (let y = 0; y < 7; y++) {
        const element = document.createElement("div");
        element.className = 'case'
        //element.setAttribute("id", index);
        element.dataset.x = x;
        element.dataset.y = y;
        element.style.background = "black";
        element.innerText = x + ';' + y
        plateau.append(element);
        console.log(element);
        

        element.addEventListener("click", ()=>{
            if(element.style.background === 'black') {
                element.style.background = joueurActuel;

                joueurActuel = joueurActuel == joueur1 ? joueur2 : joueur1
            }

/**
 * la condition ci-dessous equivaut à la condition ternaire ci-dessus 
    if(joueurActuel == joueur1) {
        joueurActuel = joueur2
    }
    else {
        joueurActuel = joueur1
    }
 */
            if(element = joueur1 || joueur2){

            }

        })
    }
}
