
function rollDice(){
    var num = Math.floor(Math.random()*7+1);
    switch(num) {
        case 1:
            document.getElementById("dice").src = "include/img/dice1.png"
            break;
        case 2:
            document.getElementById("dice").src = "include/img/dice2.png"
            break;
        case 3:
            document.getElementById("dice").src = "include/img/dice3.png"
            break;
        case 4:
            document.getElementById("dice").src = "include/img/dice4.png"
            break;
        case 5:
            document.getElementById("dice").src = "include/img/dice5.png"
            break;
        case 6:
            document.getElementById("dice").src = "include/img/dice6.png"
            break;
        }
}
function diceNumber(){
    var number = parseInt(document.getElementById("input").value);
    var dices = "";
    for(let i = 1; i <= number; i++){
        dices += document.getElementById("test").innerHTML; 
    }
    document.getElementById("test").innerHTML = dices;
}
