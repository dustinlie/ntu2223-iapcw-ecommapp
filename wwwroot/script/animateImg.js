let ppMainImg = document.getElementById('pp-image')

function bigImage() {
    ppMainImg.classList.toggle("bigImg");
}

ppMainImg.addEventListener('click', bigImage);