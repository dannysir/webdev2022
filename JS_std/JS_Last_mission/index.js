const titleMessage = document.querySelector(".title-message");
const body = document.querySelector("body");
const myBg = [
    "1.jpg",
    "2.jpg",
    "3.jpg",
    "4.jpg",
    "5.jpg",
    "6.jpg",
    "7.jpg",
    "8.jpg",
    "9.jpg",

]
function setClock(){
    const time = new Date();
    const hour = String(time.getHours()).padStart("2", 0);
    const min = String(time.getMinutes()).padStart("2", 0);
    const sec = String(time.getSeconds()).padStart("2", 0);
    titleMessage.innerText = `${hour}시 ${min}분 ${sec} 초`
}
setClock();
setInterval(setClock, 1000);

const randomNum = Math.floor(Math.random()*myBg.length);
const bgImage = myBg[randomNum];
body.style.backgroundImage = `url(img/${bgImage})`;