
const n = 5;
const m = 12;
const table = document.querySelector("table");


function showBoard() {
    table.innerHTML = "";
    
    for (let i = 0; i < n; i++) {
        const tr = document.createElement("tr");
        for (let j = 0; j < m; j++) {
            const td = document.createElement("td");
            td.innerText = ".";
            
            tr.appendChild(td);
        }
        table.appendChild(tr);
    }
    
    button.removeEventListener("click",startGame);
    button.disabled = true;
}


//----------------------------------------------------------------------------------------//
function Rokaesnyuszko(){
    const fox ={
        x: 4,
        y: 11
    }
    const nyuszikamuszika={
        x: oszlopgeneral(),
        y: sorgeneralas()
    }
    table.rows[fox.x].cells[fox.y].innerText = "🦊";
    table.rows[nyuszikamuszika.x].cells[nyuszikamuszika.y].innerText = "🐰";
}

function oszlopgeneral(){
    return Math.floor(Math.random() * (5 - 0) + 0);
}

function sorgeneralas() {
    return Math.floor(Math.random() * (6 - 0) + 0);
}
//----------------------------------------------------------------------------------------//

function rokaMozgas(e) {
    if (e.key == "keydown") {
        
    }
}


function startGame() {
    showBoard();
    Rokaesnyuszko();
    rokaMozgas();
    
}
const button = document.querySelector("input");
button.addEventListener("click", startGame);