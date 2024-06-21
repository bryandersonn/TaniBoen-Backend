function showText(button) {
    var text = button.textContent;
    document.getElementById('selectedDelivery').textContent = text.split('|')[0].trim();
    document.getElementById('result').textContent = text;
}

document.addEventListener('DOMContentLoaded', () => {
    const decreaseBtn = document.getElementById("decreaseButton");
    const increaseBtn = document.getElementById("increaseButton");
    const countLabel = document.getElementById("countLabel");
    let count = 0;
    let maxStock = 50;

    decreaseBtn.onclick = function() {
        if (count > 0) {
            count--;
            countLabel.textContent = count;
        }
    }

    increaseBtn.onclick = function() {
        if(count < maxStock)
            count++;
            countLabel.textContent = count;
    }
});

const products =[
    {name: 'brocoli', price:7000, description:'Sayur Brocoli Segar'},
    {name: 'wortel', price:10000, description:'Sayur Wortel Segar'},
    {name: 'kol', price:5000, description:'Sayur Kol Segar'}

]


