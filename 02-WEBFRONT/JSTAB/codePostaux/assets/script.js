function createOption(data){
    let tableData = data.sort((a,b)=>{
        if (a.nomCommune<b.nomCommune)
            return -1;
         else if (a.nomCommune>b.nomCommune)
            return 1;
         else{
            return 0;
         }
         

    });

    
const mySelect = document.getElementById("commune");

    for (let i = 0; i < tableData.length; i++) {
        const myOption = document.createElement("option");
            //const myOption=  new Option();
            myOption.value = tableData[i].codeCommune;
            myOption.textContent = tableData[i].nomCommune;
            mySelect.appendChild(myOption);

        
    }
}




fetch("https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json")
.then(Response => {
    return Response.json();
})
.then(data => {
    createOption(data);


    const mySelect = document.getElementById("commune");
    document.querySelector("#btncp").addEventListener("click", function(){
        
        let index = mySelect.selectedIndex;
            console.log(index);
        let ville = data.find((uneVille) => uneVille.codeCommune==mySelect[index].value)
;            
            console.log(ville);

        	const message = document.getElementById("info");
            message.innerHTML = `nom de commune : ${ville.nomCommune} <br> codde postal de la commune est : ${ville.codePostal} <br> libelle acheminement : ${ville.libelleAcheminement}`;


            
});
        
        
    })
