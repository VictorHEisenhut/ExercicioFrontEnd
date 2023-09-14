function calculaMedia(){

    let nome = document.getElementById("nome").value
    let pnota = parseFloat(document.getElementById("primeiraNota").value)
    let snota = parseFloat(document.getElementById("segundaNota").value)
    let tnota = parseFloat(document.getElementById("terceiraNota").value)
    let freq = parseInt(document.getElementById("freq").value)

    let media = ((pnota + snota + tnota) / 3).toFixed(2);

    if(media >= 6 && freq >= 70){
        document.getElementById("result").innerHTML = nome + " foi aprovado! Média: " + media + " Frequência: " + freq
    }
    else{
        document.getElementById("result").innerHTML = nome + " foi reprovado! Média: " + media + " Frequência: " + freq
    }


}