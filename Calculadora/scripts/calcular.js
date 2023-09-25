let n1 = 0;
let n2 = 0;
let op = "";

function inserir(item){
    document.getElementById("display").value += item.innerHTML
    event.preventDefault();
}

function definirOp(item) {
    op = item.value;
    console.log(op)
    let display = document.getElementById("display")
    n1 = parseFloat(display.value);
    console.log(n1)

    display.value = "";
    event.preventDefault();

}


function calc(){
    let display = document.getElementById("display")
    n2 = parseFloat(display.value);
    console.log(n2)    
    let result = 0
    console.log(result)

    switch(op){
        case "+": result = n1 + n2;
        break;
        
        case "-": result = n1 - n2;
        break;

        case "×": result = n1 * n2;
        break;

        case "÷": result = n1 / n2;
        break;
    }

    display.value = result;
    event.preventDefault();
}