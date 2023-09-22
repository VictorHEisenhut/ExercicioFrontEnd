 
        let dados = [];
        function gerarTabela(){
            
            const contato =  {
                name: document.getElementById("nome").value, 
                email: document.getElementById("email").value, 
                tel: document.getElementById("telefone").value
            };

            if(contato){}
            dados.push(contato);
            
        }
       
        
        function listarTabela(){
            
            let itens = "";
            for (let i = 0; i < dados.length; i++) {
                
                itens += `
                <tr>
                    <td>${dados[i].name}</td>
                    <td>${dados[i].email}</td>
                    <td>${dados[i].tel}</td>
                    <td><button class="btnForm" onclick=excluir('${i}')>Excluir</button></td>
                    <td><button class="btnForm" onclick=editar("${i}")>Editar</button></td>
                    </tr>
                    `
                    
            }
            document.getElementsByTagName("tbody")[0].innerHTML = itens;
        }

        function excluir(index){
            console.log(dados[index])
            dados.splice(index,1)
            listarTabela();
        }

        function editar(index) {
            
            let campoNome = document.getElementById("nome").value;
            let campoEmail = document.getElementById("email").value;
            let campoTelefone = document.getElementById("telefone").value;

            if(campoTelefone != ""){
                dados[index].tel= campoTelefone 
            }   
            if(campoEmail != ""){
                dados[index].email= campoEmail 
                
            }
            if(campoNome != ""){
                dados[index].name = campoNome
                
            }
            listarTabela();

            console.log(campoNome)

        }