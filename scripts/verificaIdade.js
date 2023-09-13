function verificarMaioridade()
{
    let vnome = document.getElementById('nome').value;
    let vidade = document.getElementById('idade').value;    
    
    if(vidade >= 18){
        document.getElementById('result').innerHTML = "Maior de idade"
    }
    else
    {
        document.getElementById('result').innerHTML = "Menor de idade"
    }
}
