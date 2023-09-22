function concedeAumento(){
    let nome = document.getElementById("nome").value;
    let salario = parseFloat(document.getElementById("salario").value);
    let cargo = document.getElementById("cargos").value;
    let salarioAumentado = 0;
    let span = document.getElementById("result")
    
    if(salario >  0){
        switch(cargo){
            case "gerente": 
            salarioAumentado = salario * 1.05;
            break;
            
            case "supervisor":
                salarioAumentado = salario * 1.08;
                break;
                
                case "operador":
                    salarioAumentado = salario * 1.09;
                    break;
                    
                    case "outro":
                        salarioAumentado *= 1.10;
                        break;
                        
                    }
    
                    let aumento = salarioAumentado - salario;
                    
        span.innerHTML = "Seu salário atual é de: " + salarioAumentado + "<br> Salário antigo: " + salario.toFixed(2) + "<br> Aumento de: " + aumento

    }
    else{
        span.innerHTML = "Salário inválido!"
    }





}