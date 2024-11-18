/*
function handleClick() {
    console.log(this.innerText);
}
const movies = document.querySelectorAll("li");
for (const movie of movies) {
    movie.addEventListener("click", handleClick);
}
*/

let first; 

function swapMovies(li1,li2){
    li1.classList.remove("swap");
    li2.classList.remove("swap");
    const temp = li1.innerText.split(". ");
    const split = li2.innerText.split(". ");
    li2.innerText = split[0]+". "+temp[1];
    li2.classList.add("swap");

    li1.innerText = temp[0]+". "+split[1];
    li1.classList.add("swap");
}
// Delegálás
// this: akihez az eseménykezelő tartozik (addEventListener) => <ul>
// e.target: akivel az esemény történt! => <li>
function handleClick(e) {
    // console.log(this.innerText);
    const li = e.target;

    if(li.matches("ul li"))
    {

        if(!first){
            li.classList.add("selected")

            first = li;
        }
        else{
            first.classList.remove("selected")

            swapMovies(first,li);
            first = null;

        }
    }
}
const ul = document.querySelector("ul");
ul.addEventListener("click", handleClick);

ul.addEventListener("animatint",afterAnimation)