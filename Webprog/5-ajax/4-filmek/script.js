// https://omdbapi.com/

const APIKEY = "404ef70b";

const URL = "http://www.omdbapi.com/";

// http://www.omdbapi.com/?apikey=14051e6b&t=Dune

async function  getMoviesAsync() {
    const input = document.querySelector("input");
    const movie = input.value;
    const response = await fetch(`${URL}?apikey-${APIKEY}&`)
}