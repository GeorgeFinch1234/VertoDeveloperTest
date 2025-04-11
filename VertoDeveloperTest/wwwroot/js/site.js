// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const inputTitle = document.querySelector('.FormTitle');
const displayTitle = document.querySelector('.outPutTitle');
const inputImg  = document.querySelector('.FormImg');
const displayImg = document.querySelector('.OutputImg');
inputTitle.addEventListener('input', ev => {
    displayTitle.textContent = inputTitle.value;
});


//browed from stack overflow
inputImg.addEventListener('change', function () {
    const file = inputImg.files[0];
    if (file) {
        const reader = new FileReader();
        reader.onload = function (e) {
            displayImg.src = e.target.result;
        };
        reader.readAsDataURL(file);
    }
});