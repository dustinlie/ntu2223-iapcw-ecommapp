let nextImg = document.getElementById('gallery-next');
let prevImg = document.getElementById('gallery-prev');
let slideIndex = 1;

showSlides(slideIndex);

function plusSlides(n) {
    showSlides(slideIndex += n);
}
  
function currentSlide(n) {
    showSlides(slideIndex = n);
}
 
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

prevImg.addEventListener('click', ()=>{
    plusSlides(-1);
});

nextImg.addEventListener('click', ()=>{
    plusSlides(1);
});

