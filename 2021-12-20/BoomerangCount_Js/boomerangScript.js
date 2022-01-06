var inputArray = [];

function resetArray(event){
    event.preventDefault();
    console.log("reseting input array");
    document.getElementById("view-array").innerHTML = "";
    document.getElementById("input-array-element").value = "";
    inputArray = [];
}
document.getElementById("reset-array-btn").addEventListener("click", resetArray);

function addElement(event){
    event.preventDefault();
    console.log("adding element");
    let inputElement = Math.floor(Number(document.getElementById("input-array-element").value));

    inputArray.push(inputElement);
    arrayView = document.getElementById("view-array");

    if(arrayView.innerHTML === ""){
        arrayView.innerHTML = inputElement;
    }else{
        arrayView.innerHTML += ", "+inputElement;
    }
}
document.getElementById("input-array-element-btn").addEventListener("click", addElement);