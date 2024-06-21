const hamburger = document.querySelector(".hamburger");
const navbarMenu = document.querySelector(".menu");

hamburger.addEventListener('click', () =>
{
    hamburger.classList.toggle("active");
    navbarMenu.classList.toggle("active");
})

document.querySelectorAll(".menu-link").forEach(n => n.addEventListener("click", () => {
    hamburger.classList.remove("active");
    navbarMenu.classList.remove("active");
}))