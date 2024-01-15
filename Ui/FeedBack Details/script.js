var str = "";
var feedbacks = [];

function addFeedback() {
    //Fill the required logic

    feedbacks[feedbacks.length] = document.getElementById("feedback").value;
  
    document.getElementById("feedback").value = "";
    document.getElementById("result").innerHTML = "<h2>Feedback Details</h2><br>Successfully Added Feedback Details!";


}

function displayFeedback() {
    //Fill the required logic
    for (var i = 1; i <= feedbacks.length; i++) {
        str = str + "Feedback " + i + "<br>" + feedbacks[i - 1] + "<br>";

    }
    document.getElementById("result").innerHTML = "<h2>Feedback Details</h2>" + str;
}
