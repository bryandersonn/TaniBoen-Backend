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

const adminButton = document.querySelector(".admin-content");
const dropdown = document.querySelector(".dropdown");

adminButton.addEventListener('click', () => {
    dropdown.classList.toggle('active')
})