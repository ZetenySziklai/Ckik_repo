// Kutya -> Mosogatás -> Szemét

function walkDog(callback) {
    const promise = new Promise(resolve =>
    ){
        setTimeout(() => {
        callback("Kutya!");
        }, 2500);
    };
    
}

function washDishes(callback) {
    return new Promise(resolve =>
        setTimeout(() => {
        resolve("Mosogatás!");
    }, 1000);
    )x
    
}

function takeTrash(callback) {
    setTimeout(() => {
        callback("Szemét!")
    }, 100);
}

// callback hell (pyramid of doom)
function chores() {
    walkDog().then(message=>
        console.log(message)
    );
}
chores();