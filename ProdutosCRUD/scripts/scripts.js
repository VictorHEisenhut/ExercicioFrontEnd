let dados = [];

let ctt = {};

function gerarTabela(){
    
    const produto =  {
        descricao: document.getElementById("desc").value, 
        valor: document.getElementById("valor").value, 
        unidades: document.getElementById("units").value
    };
    
    for (let index = 0; index < dados.length; index++) {
        if(dados[index].descricao == produto.descricao){
            document.getElementById("desc").focus()
            document.getElementById("desc").classList.add("is-invalid")
            return;
        }
    }
    if (produto.descricao == "") {
        document.getElementById("desc").classList.add("is-invalid")
        return;
    }
    else{
        document.getElementById("desc").classList.remove("is-invalid")
    }

    if (produto.valor == "") {
        document.getElementById("valor").classList.add("is-invalid")
        return;
    }
    else{
        document.getElementById("valor").classList.remove("is-invalid")
    }

    if(produto.unidades == ""){
        document.getElementById("units").classList.add("is-invalid")
        return
    }
    else{
        document.getElementById("units").classList.remove("is-invalid")
    }

    
    
    dados.push(produto);

    listarTabela();
    
}

function listarTabela(){
            
    let itens = "";
    let total = ""
    let subtotal = 0;
    for (let i = 0; i < dados.length; i++) {
        
        itens += `
        <tr>
            <td>${i + 1}</td>
            <td>${dados[i].descricao}</td>
            <td>${dados[i].valor}</td>
            <td>${dados[i].unidades}</td>
            <td>${dados[i].valor * dados[i].unidades}</td>
            <td><button class="btn btn-danger" onclick=excluir('${i}')>Excluir</button></td>
            <td><button class="btn btn-success" onclick=editar("${i}")>Editar</button></td>
            </tr>
            `
            subtotal += dados[i].valor * dados[i].unidades;
    }
    let somaValor = 0;
    let somaUnits = 0
    for (let i = 0; i < dados.length; i++) {

        somaValor += parseFloat(dados[i].valor);
        somaUnits += parseFloat(dados[i].unidades);
    }
    total = `
        <th scope="col">TOTAL</th>
        <th>${dados.length}</th>
        <th>${somaValor}</th>
        <th>${somaUnits}</th>
        <th>${subtotal}</th>
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

