console.log("kapcsolat");

const button = document.getElementById("buttonGenerate");
button.addEventListener("click",TableGenerate);

function TableGenerate(){
    //adatok
    const row = document.getElementById("rowInput").value;
    const col = document.getElementById("columnInput").value;

    //tablamegjelenítés - tábla visszaadása

    const table = ShowTable(row, col);
    //mibe generálja
    const div = document.getElementById("tableDiv");
    div.appendChild(table);
}

function ShowTable(row, col)
{
    const table = document.createElement("table");
    table.innerHTML="";
    for(let i = 0; i<row; i++)
    {
        const tr = document.createElement("tr");
        for(let j = 0; j<col;j++)
        {
            const td = document.createElement("td");
            td.innerText = "X";
            tr.appendChild(td);
        }
        table.appendChild(tr);
    }
    return table;
}

