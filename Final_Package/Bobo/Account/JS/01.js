const showPasswordButton = document.querySelector('.show-password');
const passwordInput = document.querySelector('#password');
let passwordVisible = false;

showPasswordButton.addEventListener('click', function () {
    if (passwordVisible) {
        passwordInput.setAttribute('type', 'password');
        passwordVisible = false;
    } else {
        passwordInput.setAttribute('type', 'text');
        passwordVisible = true;
    }
});
