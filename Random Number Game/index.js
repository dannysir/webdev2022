const limitNum = document.querySelector(".limitNum");
const userNum = document.querySelector("#setNum input");
const setNumForm = document.querySelector("#setNum");
const talk = document.querySelector("#talk");
const answer = document.querySelector("#result");

function getLimitNum(event) {
  event.preventDefault();
  const maxNum = limitNum.value;
  const chooseNum = userNum.value;
  const randomNum = Math.floor(Math.random()*(maxNum-1)+1);
  if(userNum !== null){
    talk.classList.remove("hidden");
    talk.innerText = `your number ${chooseNum} computer choose ${randomNum}`

  }else{
    alert("set number!");
  }

  if(chooseNum == randomNum){
    answer.innerText = "";
    //talk.classList.remove("hidden");
    answer.innerText = "You Won";
    alert("hi")
  }else if(chooseNum != randomNum){
    answer.innerText = "";
    //talk.classList.remove("hidden");
    answer.innerText = "You lose";
  }
}

setNumForm.addEventListener("submit", getLimitNum);
