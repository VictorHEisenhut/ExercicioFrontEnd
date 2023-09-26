function validaLogin(){
    let vemail = document.getElementById('email').value;
    let arroba = vemail.includes("@")
    let com = vemail.includes(".com")
    if(vemail == "" || arroba != true || com != true)
    {
        alert("Informe um email válido!");
        vemail.focus()
        return;
    }
    
    alert('Email ' + vemail + ' cadastrado!');
}

function validaCadastro(){
    let vemail = document.getElementById('email').value;
    let arroba = vemail.includes("@")
    let com = vemail.includes(".com")
    if(vemail == "" || arroba != true || com != true)
    {
        alert("Informe um email válido!");
        vemail.focus()
        return;
    }
    
    let vsenha = document.getElementById('senha').value;
    let vconfirmacao = document.getElementById('confirmacao').value;

    if(vsenha.length < 3 ) 
    { 
        alert("Senha deve possuir no mínimo 3 caracteres")
        vsenha.focus();
        return;
    }
    if(vsenha != vconfirmacao){
        alert("Senhas não compatíveis")
        vsenha.focus();
        return;
    }

    let vcpf = document.getElementById('cpf').value;

    if(vcpf.length != 11)
    {
        alert("CPF inválido")
        vcpf.focus();
        return;
    }



    let vmasc = document.getElementById('genero_masculino').value;
    let vfem = document.getElementById('genero_feminino').value;

    if(!vmasc.checked && !vfem.checked)
    {
        alert("Você deve selecionar um campo")
        return;
    }

    alert("Cadastrado com sucesso")
}
