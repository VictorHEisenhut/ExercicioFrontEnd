let info = [];

function ordenar(){
    
    for (let i = 0; i < info.length; i++) {

        for (let j = 0; j < (info.length - i - 1); j++) {

            if(info[j] > info[j + 1]){
                var temp = info[j]
                info[j] = info[j + 1]
                info[j + 1] = temp;
            }
        }
        
    }

    listarArray();
   
}

function inserirNoArray() {
    
    let numero = parseInt(document.getElementById("inputN").value);

    if(!info.includes(numero)){
        info.push(numero)
    }
    else{
        alert("Insira um número válido")
    }
    event.preventDefault();
}

function listarArray() {
    let i = 0;
    let itens = "";
    while(i < info.length) {
        itens += `<li>${info[i]}</li>`

        i++
    }
    console.log(itens)
    document.getElementsByTagName("ul")[0].innerHTML = itens
}