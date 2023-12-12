var rgb = document.getElementById("rgb"); 
var message = document.getElementById("message");
var h1 = document.querySelector("h1");
var resetButton = document.querySelector("#reset");
var easyButton = document.querySelector("#easy");
var hardButton = document.querySelector("#hard");
var squares = document.querySelectorAll(".square"); 
// ----------------------------------------
var numberOfSquares = 6;
makeGame();
var pickedColer;

resetButton.addEventListener("click", makeGame);
easyButton.addEventListener("click", function(){
    numberOfSquares = 3;
    makeGame();
    easyButton.classList.add("selected");
    hardButton.classList.remove("selected");
});
hardButton.addEventListener("click", function(){
    numberOfSquares = 6;
    makeGame();
    easyButton.classList.remove("selected");
    hardButton.classList.add("selected");
});

function makeGame(){ 
    message.textContent = "";

    for (var i = 0; i < numberOfSquares; i++){
        squares[i].removeEventListener("click", checkColors); 
    }

    for (var i = 0; i < 6; i++){
        squares[i].style.backgroundColor = "#232323";  
    }

    // reset h1 color after change
    h1.style.backgroundColor = "steelblue";  
    colors = createColors(numberOfSquares);
    pickedColer = colors[Math.floor(Math.random() * numberOfSquares)];
    console.log(pickedColer)
    rgb.textContent = pickedColer;

    for (var i = 0; i < numberOfSquares; i++){
        squares[i].addEventListener("click", checkColors); 
        squares[i].style.backgroundColor = colors[i]; 
    }    
}


// --------------------------------------------
function changeColors(){
    for (var j = 0; j < numberOfSquares; j++){
        h1.style.backgroundColor = pickedColer;
        squares[j].style.backgroundColor = pickedColer;
    }
}

function checkColors(){
    console.log(this.style.backgroundColor, pickedColer)
    if (this.style.backgroundColor == pickedColer){
        message.textContent = "Correct!";
        resetButton.textContent = "Play Again?";
        changeColors();        
    }
    else{
        this.style.backgroundColor = "#232323";
        message.textContent = "Try Again!";
    }
}


function createColors(num){
    var colors = [];
    for (var j = 0; j < num; j++){
        colors.push("rgb(" + Math.floor(Math.random() * 256) + ", " + Math.floor(Math.random() * 256) + ", " + Math.floor(Math.random() * 256) + ")");
    }
    return colors;
}



