function verificarMaioridade()
{
    let vnome = document.getElementById('nome').value;
    let vidade = document.getElementById('idade').value;    
    
    if(vnome != "" && vidade > 0 && vidade < 130){
        if(vidade >= 18){
            document.getElementById('result').innerHTML = vnome + " é maior de idade"
        }
        else
        {
            document.getElementById('result').innerHTML = "Menor de idade"
        }
    }
    else{
        document.getElementById('result').innerHTML = "Valores inválidos!"

    }


}
