const hamburger = document.querySelector(".hamburger img");
const navbarItems = document.querySelector(".space");
const main = document.querySelector("main");
const footer = document.querySelector("footer");
const topshadow = document.querySelector(".top");

hamburger.addEventListener('click', () => {
    navbarItems.classList.toggle('active')
    main.classList.toggle('active')
    footer.classList.toggle('active')
    topshadow.classList.toggle('active')

})

const formLogin = document.getElementById("form-login");
const inputEmail = document.getElementById("input-email");
const inputPass = document.getElementById("input-pass");

formLogin.onsubmit = function (event) {
    event.preventDefault();

    const email = inputEmail.value;

    if (email.length === 0) //check if email is not null
    {
        alert("Email name must at least be 3 letters");
        return;
    }

    if (email.length <= 2) //check length email
    {
        alert("Email name must at least be 3 letters");
        return;
    }

    if (email.indexOf("@") == -1) //checkk @
    {
        alert("Email must contain @");
        return;
    }

    var parts = email.split("@");
    var dot = parts[1].indexOf(".");
    var dotSplits = parts[1].split(".");
    var dotCount = dotSplits.length - 1;

    if (dot == -1 || dot < 1 || dotCount > 2) { //checking if dot is there and character after @ must be > 0
        alert("Email must have dot and a minimum of 1 character after @");
        return;
    }

    for (var i = 0; i < dotSplits.length; i++) { //checking if dot is not the last character and dots are not repeated
        if (dotSplits[i].length == 0) {
            alert("Dot cannot be last character or repeated");
            return;
        }
    }

    const pass = inputPass.value;

    if (pass.length === 0) {
        alert("Password must be filled."); //password must be filled
        return;
    }

    document.getElementById("form-login").submit();
}
