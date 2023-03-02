let next = document.getElementById('pp-gallery-next')

let formButton = document.getElementById('account');
let formExit = document.getElementById('form-exit');

let slideIndex = 1;
showSlides(slideIndex);



function showSlides(n) {
    let i;
    let slides = document.getElementsByClassName("gallery-images");
    if (n > slides.length) {slideIndex = 1}    
    if (n < 1) {slideIndex = slides.length}
    for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";  
    }
    slides[slideIndex-1].style.display = "block";  
}

function plusSlides(n) {
    showSlides(slideIndex += n);
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}

function test() {
    document.body.style.backgroundColor = "#000000"
}

next.addEventListener('click', test)


function openForm() {
    document.getElementById("form-popup").style.display = "block";
}
  
function closeForm() {
    document.getElementById("form-popup").style.display = "none";
} 
  
formButton.addEventListener('click', openForm);
formExit.addEventListener('click', closeForm);