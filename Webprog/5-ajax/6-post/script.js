const button = document.querySelector("button");

async function createUser(){
    const name = document.querySelector("#name").value;
    const job = document.querySelector("#job").value;
    const user ={name,job};
    const OPTIONS={
        method:"POST",
        body:JSON.stringify(user),
        headers:{
            "Content-Tpye":"application/json"
        },
        body:jsonqqq
    };
    const response = await fetch("https://reqres.in/api/user",OPTIONS);
    const data = await response.json();
    cons
}

button.addEventListener("click",createUser);