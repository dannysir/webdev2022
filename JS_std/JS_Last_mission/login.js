const login = document.getElementById("login");
const helloMessage = document.querySelector(".helloMessage")
const loginInput = document.querySelector("#login input");
const hello = document.querySelector("#hello");
const Iam = [];

function saveMyName(){
    localStorage.setItem("userName", Iam);
}

// function logOut(event){
//     const li = event.target.parentElement;
//     li.remove();
//     toDos = toDos.filter((toDo) => toDo.id !== parseInt(li.id));
//     saveToDos();
// }

function paintHello(myName){
    hello.innerText = `Hello ${myName}`;
    hello.classList.remove("hidden");
    login.classList.add("hidden");
    helloMessage.classList.add("hidden")
    // const button = document.createElement("button");
    // button.innerText = "❌" 
    // hello.appendChild(button);
}

function handleLogin(event){
    event.preventDefault();
    const myName = loginInput.value;

    loginInput.value = "";
    Iam.push(myName);
   // paintToDo(myName);
    saveMyName();

    paintHello(myName)
}

login.addEventListener("submit", handleLogin);
