document.querySelectorAll('.g-content img').forEach(image => {
    image.onclick = () => {
        document.querySelectorAll('.popup-img').style.display = "block";
        document.querySelectorAll('.popup-img img').src = image.getAttribute('src');
    }
});

document.querySelector('.popup-img .close').onclick = () => {
    document.querySelectorAll('.popup-img').style.display = "none";
}