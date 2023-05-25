const dialogBox = document.getElementById('dialog-box');
const dialogTitle = document.getElementById('dialog-title');
const dialogCloseBtn = document.getElementById('dialog-close-btn');
const dialogBody = document.getElementById('dialog');
const dialogInput = document.getElementById('dialog-input');
const dialogSendBtn = document.getElementById('dialog-send-btn');

let IsShowedDialog = false;

function ShowDialog() {
    dialogBox.style.display = 'flex';
    IsShowedDialog = true;
}

function HideDialog() {
    dialogBox.style.display = 'none';
    IsShowedDialog = false;
}

this.addEventListener('keypress', function (e) {
    if (e.key === 'Enter' && IsShowedDialog) {
        HideDialog();
    }
    else if ((e.key === 'Enter' && !IsShowedDialog)) {
        ShowDialog();
    }
})

dialogCloseBtn.addEventListener('click', HideDialog);
dialogInput.addEventListener('keypress', function (e) {
    if (e.key === 'Enter') {

    }
})