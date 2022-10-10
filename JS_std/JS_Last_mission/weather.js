const API_KEY = "da1ceb8dec34515a33418dd334898c3e"
function onGeoOk(position){
    const lat = position.coords.latitude;
    const lng = position.coords.longitude;
    const url = `https://api.openweathermap.org/data/2.5/weather?lat=${lat}&lon=${lng}&appid=${API_KEY}&units=metric`
    fetch(url)
    .then(Response => Response.JSON())
    .then(data => {
        
        const weather = document.querySelector("#weather span:first-child");
        const city = document.querySelector("#weather span:last-child");
        weather.innerText = `${data.weather[0].main}  / ${data.main.temp}`;
        city.innerText = data.name;
    });
}
function onGeoError(){
    alert("Can't Find Location")
}

navigator.geolocation.getCurrentPosition(onGeoOk,onGeoError)