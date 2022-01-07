var inputArray = [];

//Resets the array specified by user
function resetArray(event){
    event.preventDefault();
    console.log("reseting input array");
    document.getElementById("view-array").innerHTML = "";
    document.getElementById("input-array-element").value = "";
    inputArray = [];
}
document.getElementById("reset-array-btn").addEventListener("click", resetArray);

//Allows user to add an integer element to the array
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

//Returns a boomerang count of a given array
function boomerangCount(inArr){
    let count = 0;
    for(let i=0; i < inArr.length - 2; i++){
        if(inArr[i] === inArr[i+2]){
            if(inArr[i] === inArr[i+1]){
                i++;
            }else{
                count++;
            }
        }
    }
    return count;
}

//Allows user to get boomerang count of the array
function initiateCount(event){
    event.preventDefault();
    alert(boomerangCount(inputArray));
}
document.getElementById("boomerang-count-btn").addEventListener("click", initiateCount);