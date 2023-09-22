function calculaMedia(){

    let nome = document.getElementById("nome").value
    let pnota = parseFloat(document.getElementById("primeiraNota").value)
    let snota = parseFloat(document.getElementById("segundaNota").value)
    let tnota = parseFloat(document.getElementById("terceiraNota").value)
    let freq = parseInt(document.getElementById("freq").value)

    if(pnota >= 0 && pnota <= 10 && snota >= 0 && snota <= 10 && tnota >= 0 && tnota <= 10 && freq >= 0 && freq <= 100){
        let media = ((pnota + snota + tnota) / 3).toFixed(2);
    
        if(media >= 6 && freq >= 70){
            document.getElementById("result").innerHTML = nome + " foi aprovado! Média: " + media + " Frequência: " + freq
        }
        else{
            document.getElementById("result").innerHTML = nome + " foi reprovado! Média: " + media + " Frequência: " + freq
        }

    }
    else{
        document.getElementById("result").innerHTML = "Valores inválidos!"

    }



}