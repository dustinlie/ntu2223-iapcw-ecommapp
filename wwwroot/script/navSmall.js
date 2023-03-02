let menu = document.getElementById('menu')
let navExit = document.getElementById('nav-close')

function navOpen() {
    document.getElementById('nav-small-screen').style.display = "block";
    menu.style.fontWeight = 'bold';
}

function navClose() {
    document.getElementById('nav-small-screen').style.display = "none";
    menu.style.fontWeight = 'normal';
}

menu.addEventListener('click', navOpen)
navExit.addEventListener('click', navClose)