window.addEventListener("load", checkView);

let viewSwitchDarkBtn = document.getElementById('view-switch-dark');
let viewSwitchLightBtn = document.getElementById('view-switch-light');

let selectText1 = document.getElementsByClassName("gallery-more");
let selectText2 = document.getElementsByClassName("product-name-home");
let selectText3 = document.getElementsByClassName("pp-product-info");
let selectText4 = document.getElementsByClassName("cp-heading");
let selectText5 = document.getElementsByClassName("nrp-heading");
let selectShadow1 = document.getElementsByClassName("product-gallery");
let selectShadow2 = document.getElementsByClassName("product-container-main");
let selectShadow3 = document.getElementsByClassName("category-gallery");

function darkMode() {
    document.body.style.backgroundColor = "#111111";
    document.getElementById("view-switch-dark").style.display = "none";
    document.getElementById("view-switch-light").style.display = "inline";
    setShadowDarkMode(selectShadow1)
    setShadowDarkMode(selectShadow2)
    setShadowDarkMode(selectShadow3)
    setTextDarkMode(selectText1)
    setTextDarkMode(selectText2)
    setTextDarkMode(selectText3)
    setTextDarkMode(selectText4)
    setTextDarkMode(selectText5)
    localStorage.view = "dark";
    console.log(localStorage.View);
}
  
function lightMode() {
    document.body.style.backgroundColor = "#ffffff";
    document.getElementById("view-switch-dark").style.display = "inline";
    document.getElementById("view-switch-light").style.display = "none";
    setShadowLightMode(selectShadow1)
    setShadowLightMode(selectShadow2)
    setShadowLightMode(selectShadow3)
    setTextLightMode(selectText1)
    setTextLightMode(selectText2)
    setTextLightMode(selectText3)
    setTextLightMode(selectText4)
    setTextLightMode(selectText5)
    localStorage.view = "light";
}

function setTextDarkMode(a) {
    for (let i = 0; i < a.length; i++) {
        a[i].style.color = "#ffffff";
    }
}

function setTextLightMode(a) {
    for (let i = 0; i < a.length; i++) {
        a[i].style.color = "#003b6f";
    }
}

function setShadowDarkMode(a) {
    for (let i = 0; i < a.length; i++) {
        a[i].style.boxShadow = "-1px -1px 15px 3px #2d2d2d";
    }  
}

function setShadowLightMode(a) {
    for (let i = 0; i < a.length; i++) {
        a[i].style.boxShadow = "-1px -1px 15px 3px #e5e5e5";
    }  
}

function checkView() {
    if(localStorage.getItem("view") === "dark") {
        document.body.style.backgroundColor = "#111111";
        document.getElementById("view-switch-dark").style.display = "none";
        document.getElementById("view-switch-light").style.display = "inline";
        setShadowDarkMode(selectShadow1)
        setShadowDarkMode(selectShadow2)
        setShadowDarkMode(selectShadow3)
        setTextDarkMode(selectText1)
        setTextDarkMode(selectText2)
        setTextDarkMode(selectText3)
        setTextDarkMode(selectText4)
        setTextDarkMode(selectText5)
        localStorage.view = "dark";
        console.log(localStorage.view);
    } else {
        lightMode;
    }
}

viewSwitchDarkBtn.addEventListener('click', darkMode);
viewSwitchLightBtn.addEventListener('click', lightMode);