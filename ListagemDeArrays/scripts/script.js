let info = [];
const aux = []

function ordenarDecrescente(){

    for (let i = 0; i < info.length; i++) {

        for (let j = 0; j < (info.length - i - 1); j++) {

            if(info[j] < info[j + 1]){
                var temp = info[j]
                info[j] = info[j + 1]
                info[j + 1] = temp;
            }
        }
        
    }

    listarArray();

}

function ordenarCrescente(){
    
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
    aux.push(info)
    document.getElementsByTagName("ul")[0].innerHTML = itens
}

function pesquisar(input){

    let num = parseFloat(document.getElementById(`${input}`).value);

    if(info.includes(num)){
        return info.indexOf(num);
    }
    else{
        return -1;
    }

}

function showIndex(){

    let input = document.getElementById("input");

    let index = pesquisar("inputNumero")

    input.value = index;

}

function excluir(){

    let index = pesquisar("inputExcluir");

    info.splice(index, 1);

    listarArray();
}

function editar(){

    let indexAntigo = pesquisar("inputAntigo");
    let indexNovo = document.getElementById("inputNovo");

    if(pesquisar("inputNovo") == -1){
        info[indexAntigo] = indexNovo.value;
        listarArray();
    }
    else{
        return;
    }
    


}