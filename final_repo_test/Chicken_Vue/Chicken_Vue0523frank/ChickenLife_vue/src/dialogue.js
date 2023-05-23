// const dialog = () => {
const dialogBox = document.getElementById('dialog-box');
const dialogTitle = dialogBox.querySelector('.dialog-title');
const dialogCloseBtn = dialogBox.querySelector('.dialog-close-btn');
const dialogBody = dialogBox.querySelector('.dialog-body');
const dialogInput = dialogBox.querySelector('#dialog-input');
const dialogSendBtn = dialogBox.querySelector('#dialog-send-btn');
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
// }

// export default dialog;