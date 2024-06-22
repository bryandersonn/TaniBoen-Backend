const formRegis = document.getElementById("form-regis");
const inputName = document.getElementById("name-input");
const inputPhone = document.getElementById("phone-input");
const inputEmail = document.getElementById("email-input");
const inputPass = document.getElementById("pass-input");
const inputConf = document.getElementById("confirm-input");
const validateBox = document.getElementById("checkbox-input");

formRegis.onsubmit = function (event) {
    event.preventDefault();

    const name = inputName.value;
    const email = inputEmail.value;
    const phone = inputPhone.value;

    if (name.length === 0) // check name is not null
    {
        alert("Name must be filled");
        return;
    }

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

    const conf = inputConf.value;

    if (pass.length === 0) {
        alert("Password must be filled."); //password must be filled
        return;
    }

    if (pass.length < 8) {
        alert("Password must be more than 8 characters."); //password length must be more than 8
        return;
    }

    const isContainsSymbol = /^(?=.*[~`!@#$%^&*()--+={}\[\]|\\:;"'<>,.?/_?]).*$/;
    if (!isContainsSymbol.test(pass)) {
        alert("Password must contain at least one special symbol.");
        return;
    }

    const isContainsUppercase = /^(?=.*[A-Z]).*$/;
    if (!isContainsUppercase.test(pass)) {
        alert("Password must have at least one uppercase character.");
        return;
    }

    const isContainsNumber = /^(?=.*[0-9]).*$/;
    if (!isContainsNumber.test(pass)) {
        alert("Password must have at least one digit.");
    }

    if (conf.length === 0) {
        alert("You must confirm your password!");
        return;
    }

    const testConf = conf;

    if (testConf != pass) {
        alert("The password does not match!");
        return;
    }

    const boxstate = validateBox.checked;

    if(boxstate == false)
    {
        alert("You must agree to the terms and conditions to continue.");
        return;
    }
    else
    {
        formRegis.submit();
        alert("Register Success!");
    }

    
}
