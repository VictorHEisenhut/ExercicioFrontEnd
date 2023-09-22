

function somar(){

    let x = parseFloat(document.getElementById("x").value)
    let y = parseFloat(document.getElementById("y").value)

    let result = x + y;
    
    document.getElementById("result").innerHTML = "O resultado é: " + result
    

}

function subtrair(){
    let x = parseFloat(document.getElementById("x").value)
    let y = parseFloat(document.getElementById("y").value)
    let result = x - y;

    document.getElementById("result").innerHTML = "O resultado é: " + result

}

function multiplicar() {
    let x = parseFloat(document.getElementById("x").value)
    let y = parseFloat(document.getElementById("y").value)
    let result = x * y;

    document.getElementById("result").innerHTML = "O resultado é: " + result

}

function dividir(){
    let x = parseFloat(document.getElementById("x").value)
    let y = parseFloat(document.getElementById("y").value)

    let result = x / y;

    document.getElementById("result").innerHTML = "O resultado é: " + result
}