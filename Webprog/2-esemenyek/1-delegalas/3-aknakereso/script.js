const n = 12;
const mineCount = 10;
let board = [];
let revealedCount = 0;

const table = document.querySelector("table");

// --------------------------------------------

function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}

function createBoard(){
    for(let i = 0;i<n;i++){
        for(let j = 0;j<n;j++){
            const field = {
                isMine: false,
                value: 0
            };
            board.push(row);
        }
    }
}

function showBoard(){

}
function startGame(){
    createBoard();
    showBoard();
}
