
let userJson = '';

function cadastrarUsuario(){
    
    let usuario = [
        {
            nome: document.getElementById("nome").value,
            email: document.getElementById("email").value,
            senha: document.getElementById("senha").value
        }
    ]

    userJson = JSON.stringify(usuario);
    alert("Cadastrado")
    localStorage.setItem('user', userJson)
}

function cadastrarMaisUsuarios(){
    let usuarios = []

            if(localStorage.getItem('usuarios')){
               usuarios = JSON.parse(localStorage.getItem('usuarios'))    
            }
                   
            let inputNome = document.getElementsByTagName('input')[0]

            let inputUser = document.getElementsByTagName('input')[1]

            let inputSenha = document.getElementsByTagName('input')[2]

            let obj = { username: inputUser.value, senha: inputSenha.value }

            usuarios.push(obj)

            localStorage.setItem('usuarios',JSON.stringify(usuarios))
}

function logarUsuario(){

    let inputUser = document.getElementsByTagName('input')[0]

            let inputSenha = document.getElementsByTagName('input')[1]

            if(localStorage.getItem('usuarios')){
              let usuarios = JSON.parse(localStorage.getItem('usuarios')) 
               for(let i = 0; i < usuarios.length; i++){
                   if(inputUser.value == usuarios[i].username && inputSenha.value == usuarios[i].senha){
                    localStorage.setItem('userLogado',JSON.stringify(usuarios[i]))
                    return
                }
               } 
               alert('Usuario ou senha incorreto')  
            }
            else{
                alert('Tabela de usuarios não encontrada')
            }   

}


function logout(){

    var user = JSON.parse(localStorage.getItem('user'))

    localStorage.removeItem('userLogado', user)
}

