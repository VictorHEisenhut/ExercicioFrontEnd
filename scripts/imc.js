function calculaIMC(){
    
    let altura = parseFloat(document.getElementById("altura").value);
    let peso = parseFloat(document.getElementById("peso").value);
    let span = document.getElementById("result")

    console.log(peso)
    console.log(altura)

    let imc = (peso / (altura * altura)).toFixed(2);
    console.log(imc)
    if(imc < 17){
        span.innerHTML = "Muito abaixo do peso, IMC: " + imc
    }
    else if(imc < 18.49){
        span.innerHTML = "Abaixo do peso, IMC: " + imc
    }
    else if(imc < 24.99){
        span.innerHTML = "Peso normal, IMC: " + imc
    }
    else if(imc < 29.99){
        span.innerHTML = "Acima do peso, IMC: " + imc
    }
    else if(imc < 34.99){
        span.innerHTML = "Obesidade I, IMC: " + imc
    }
    else if(imc < 39.99){
        span.innerHTML = "Obesidade II (severa), IMC: " + imc
    }
    else{
        span.innerHTML = "Obesidade III (mórbida), IMC: " + imc
    }


}