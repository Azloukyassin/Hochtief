doFunction() 
{
    var projects = document.getElementById("projects");
    if (projects.textContent == "A60") {
        return "A60"; 
    }
    else if (projects.textContent == "A6") {
        return "A6";
    }
    else if (projects.textContent == "ICE") {
        return "ICE";
    }
    else if (projects.textContent == "MDB") {
        return "MDB";
    }
    else
        return "U3"; 
} 

function onInput() {
    var val = document.getElementById("input").value;
    var opts = document.getElementById('dlist').childNodes;
    for (var i = 0; i < opts.length; i++) {
        if (opts[i].value === val) {
            // An item was selected from the list!
            // yourCallbackHere()
            alert(opts[i].value);
            break;
        }
    }
}