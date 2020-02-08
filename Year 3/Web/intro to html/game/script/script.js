var number = 0;
var count = 0;
var coins = [500,1000,1500,2000,2500,3000,3500,4000,4500,5000,6000,7000];

function reset(){
    count = 0;
    number = Math.floor(Math.random()*50) + 1;
    document.getElementById("sphereText").innerHTML = number;
}

function up(){
    
    rand = Math.floor(Math.random()*50) + 1;
    if(rand>=number){
        count++;
        number = rand;
        document.getElementById("sphereText").innerHTML = number;
    }
    else{
        
        count = 0;
        document.getElementById("sphereText").innerHTML = 'X';
    }
}

function down(){
    
    rand = Math.floor(Math.random()*50) + 1;
    if(rand<=number){
        count++;
        number = rand;
        document.getElementById("sphereText").innerHTML = number;
    }
    else{
        
        count = 0;
        document.getElementById("sphereText").innerHTML = 'X';
    }
}
function get(){
    alert("You won!"+ coins[count]);
    reset();
}