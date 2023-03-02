window.onload = checkFont();

let textIncButton = document.getElementById('text-inc');
let textDecButton = document.getElementById('text-dec');
let textResetButton = document.getElementById('text-reset');

function textIncrease() {
    document.body.style.fontSize = "larger";
    localStorage.font = "plus";
}

function textDecrease() {
    document.body.style.fontSize = "smaller";
    localStorage.font = "min";
    console.log(localStorage.font);
}

function textReset() {
    document.body.style.fontSize = "initial";
    localStorage.font = "";
}

function checkFont() {
    if (localStorage.getItem("font") === "plus") {
        document.body.style.fontSize = "larger";
        console.log("big");
    } else if (localStorage.getItem("font") === "min") {
        document.body.style.fontSize = "smaller";
        console.log("small");
    } else {
        document.body.style.fontSize = "initial";
        console.log("reg");
    }
}

textIncButton.addEventListener('click', textIncrease)
textDecButton.addEventListener('click', textDecrease)
textResetButton.addEventListener('click', textReset)