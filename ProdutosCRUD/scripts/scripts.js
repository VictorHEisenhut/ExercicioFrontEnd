let dados = [];

let ctt = {};

function gerarTabela(){
    
    const produto =  {
        descricao: document.getElementById("desc").value, 
        valor: document.getElementById("valor").value, 
        unidades: document.getElementById("units").value
    };

    if(produto){}
    dados.push(produto);

    listarTabela();
    
}

function listarTabela(){
            
    let itens = "";
    let total = ""
    for (let i = 0; i < dados.length; i++) {
        
        itens += `
        <tr>
            <td>${i + 1}</td>
            <td>${dados[i].descricao}</td>
            <td>${dados[i].valor}</td>
            <td>${dados[i].unidades}</td>
            <td><button class="btn btn-danger" onclick=excluir('${i}')>Excluir</button></td>
            <td><button class="btn btn-success" onclick=editar("${i}")>Editar</button></td>
            </tr>
            `
            
    }
    let somaValor = 0;
    let somaUnits = 0
    for (let i = 0; i < dados.length; i++) {

        somaValor += parseInt(dados[i].valor);
        somaUnits += parseInt(dados[i].unidades);
    }

    total = `
        <th scope="col">TOTAL</th>
        <th>${dados.length}</th>
        <th>${somaValor}</th>
        <th>${somaUnits}</th>
        <th></th>
        <th></th>
     `
    document.getElementById("tr").innerHTML = total;
    document.getElementsByTagName("tbody")[0].innerHTML = itens;
}

function excluir(index){
    console.log(dados[index])
    dados.splice(index,1)
    listarTabela();
}

function editar(index) {
    
   ctt = dados[index];

   document.getElementById("desc").value = ctt.descricao;
   document.getElementById("valor").value = ctt.valor;
   document.getElementById("units").value = ctt.unidades;

   document.getElementById("cadastrar").setAttribute("disabled", "true");
   document.getElementById("editar").removeAttribute("disabled");

}

function editarProdutos(){

    ctt.descricao = document.getElementById("desc").value;
    ctt.valor = document.getElementById("valor").value;
    ctt.unidades = document.getElementById("units").value;

    document.getElementById("cadastrar").removeAttribute("disabled");
    document.getElementById("editar").setAttribute("disabled", "true");

    listarTabela();
}

