const clockTitle = document.querySelector(".js-clock");

function getClock(){
    const xmas = new Date(2022, 12, 25);
    const sanDate = new Date();
    const gap = xmas - sanDate
    const gapDay = Math.ceil(gap/(1000*60*60*24));
    const gapHour = Math.ceil((gap%(1000*60*60*24))/(1000*60*60));
    const gapMin = Math.ceil((gap%(1000*60*60))/(1000*60));
    const gapSec = Math.ceil((gap%(1000*60))/1000);
    const days = String(gapDay).padStart(2,"0");
    const hour = String(gapHour).padStart(2,"0");
    const min = String(gapMin).padStart(2,"0");
    const sec = String(gapSec).padStart(2,"0");
    clockTitle.innerText = `${days}d ${hour}h ${min}m ${sec}s`;
}
getClock()
setInterval(getClock, 1000);