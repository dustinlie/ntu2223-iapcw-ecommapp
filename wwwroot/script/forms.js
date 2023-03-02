let formButton = document.getElementById('account');
let formExitLog = document.getElementById('login-form-exit');
let formExitReg = document.getElementById('register-form-exit');
let registerForm = document.getElementById('to-register');
let loginForm = document.getElementById('to-login');

function registration() {
    document.getElementById("register-form-container").style.display = "block";
    document.getElementById("login-form-container").style.display = "none";
}
  
function login() {
    document.getElementById("register-form-container").style.display = "none";
    document.getElementById("login-form-container").style.display = "block";
}
  
registerForm.addEventListener('click', registration);
loginForm.addEventListener('click', login);
  
function openForm() {
    document.getElementById("form-popup").style.display = "block";
}
  
function closeForm() {
    document.getElementById("form-popup").style.display = "none";
} 
  
formButton.addEventListener('click', openForm);
formExitLog.addEventListener('click', closeForm);
formExitReg.addEventListener('click', closeForm);