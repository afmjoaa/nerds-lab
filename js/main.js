// JavaScript functions to open and close the modal
function openModal() {
    document.getElementById('modalBackground').style.display = 'block';
}

function closeModal(event) {
    if (event.target === document.getElementById('modalBackground')) {
        document.getElementById('modalBackground').style.display = 'none';
    }
}

function stopPropagation(event) {
    event.stopPropagation();
}
