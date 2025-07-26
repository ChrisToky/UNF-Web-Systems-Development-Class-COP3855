// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Modal functionality
var modal = document.getElementById("myModal");

function showModal() {
    modal.style.display = "block";
}

function closeModal() {
    modal.style.display = "none";
}

function openView() {
    // Open another view or redirect to another page
    window.location.href = "another_view.html";  // example: navigate to another page
}

// Close the modal when the user clicks anywhere outside of it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
