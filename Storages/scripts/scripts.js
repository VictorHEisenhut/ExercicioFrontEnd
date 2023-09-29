
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
    var users = [localStorage.getItem('user')]
            if(users != ""){

                users = JSON.parse(users)
                let newUser = {
                    nome: document.getElementById("nome").value,
                    email: document.getElementById("email").value,
                    senha: document.getElementById("senha").value
                }
                users.push(newUser)
            }
            else{


                let newUser = {
                    nome: document.getElementById("nome").value,
                    email: document.getElementById("email").value,
                    senha: document.getElementById("senha").value
                }
                users.push(newUser)
            }

        localStorage.setItem('user', JSON.stringify(users))
        
}

function logarUsuario(){

    var user = JSON.parse(localStorage.getItem('user'))

    let emailV = document.getElementById("emailLogin").value;
    let senhaV = document.getElementById("senhaLogin").value;

    if(user[0].email == emailV && user[0].senha == senhaV ){
         alert("Login com sucesso")
         window.location.href("/pages/index.html")
    }

}


function logout(){

    var user = JSON.parse(localStorage.getItem('user'))

    localStorage.removeItem('user', user)
}

