// GLOBÁLIS VÁLTOZÓK, KONSTANSOK
const n = 12; // 12x12
const mineCount = 10;
let board = []; // mátrix - játék állapottér, mezőket tartalmaz
let revealedCount = 0;

const table = document.querySelector("table");

// --------------------------------------------

function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}

// --------------------------------------------

function generateMines() {
    let db = 0;
    while (db < mineCount) {
        const sor = randint(0, n-1); // x. sor
        const oszlop = randint(0, n-1); // y. cella
        if (!board[sor][oszlop].isMine) {            
            board[sor][oszlop].isMine = true;
            for (let i = sor-1; i <= sor+1; i++) {
                for (let j = oszlop-1; j <= oszlop+1; j++) {
                    if (0 <= i && i < n && 0 <= j && j < n && !(i === sor && j === oszlop)) {
                        board[i][j].value++;
                    }
                }
            }
            db++;
        }
    }
}

// Készítse el a kezdeti mátrixomat!
// field = {isMine: ???, value: ???}
function createBoard() {
    for (let i = 0; i < n; i++) {
        const row = [];
        for (let j = 0; j < n; j++) {
            const field = {
                isMine: false,
                value: 0,
                isRevealed: false,
                isFlagged: false
            };
            row.push(field);
        }
        board.push(row);
    }
    generateMines();
}

function getText(i, j) {
    if (!board[i][j].isRevealed) return "";
    else if (board[i][j].isMine) return "💣";
    else if (board[i][j].value === 0) return "";
    else if(board[i][j].isFlagged) return "🚩";
    else return board[i][j].value;
}

// A mátrix alapján jelenítse meg a táblázatot!
// Nem board[i, j]
function showBoard() {
    table.innerHTML = "";
    for (let i = 0; i < n; i++) {
        const tr = document.createElement("tr");
        for (let j = 0; j < n; j++) {
            const td = document.createElement("td");
            td.innerText = getText(i, j);
            if (board[i][j].isRevealed) {
                td.classList.add("revealed");
            }
            tr.appendChild(td);
        }
        table.appendChild(tr);
    }
}

// Felfedi az (i, j) cella szomszédait!
function revealNeighbours(i, j) {
    for (let x = i-1; x <= i+1; x++) {
        for (let y = j-1; y <= j+1; y++) {
            if (0 <= x && x < n && 0 <= y && y < n && !board[x][y].isRevealed) {
                reveal(x, y);
            }
        }
    }
}

// Felfedi az (i, j) cellát! (Egy darabot!)
function reveal(i, j) {
    board[i][j].isRevealed = true;
    revealedCount++;    
    if (board[i][j].value === 0) {
        revealNeighbours(i, j);
    }
    showBoard();
}

// Felfedtük az (i, j) mezőt.
// Ellenőrizzük, hogy véget ért-e a játék!
function checkGameEnd(i, j) {
    if(board[i][j].isMine){
        table.removeEventListener("click",handleClick);
    }
    else if(revealedCount + mineCount=== n*n){
        table.removeEventListener("click",handleClick);
    }
}

// JS objektumként: td.__proto__
function handleClick(e) {
    const td = e.target; // i. sor j. cellája <td>
    if(td.matches("table td")){return;}
    const j = td.cellIndex; // Hanyadik cella = hanyadik oszlop?
    const tr = td.parentNode;
    const i = tr.rowIndex; // Hanyadik sor?
    reveal(i, j);
    checkGameEnd(i, j);
}
function handleFlag(e){
    e.preventDefault();
    const td = e.target;
    const i = td.cellIndex;
    const tr = td.parentNode;
    const j = tr.cellIndex;
    board[i][j].isFlagged = true;
}

function startGame() {
    board = [];
    revealedCount = 0;
    createBoard();
    showBoard();
    table.addEventListener("click", handleClick);
}
const button = document.querySelector("button");
button.addEventListener("click", startGame);