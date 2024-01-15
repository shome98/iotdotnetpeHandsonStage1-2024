
function calculateEMI(){
    P=document.getElementById("principalAmount").value;
    r=document.getElementById("interestRate").value;
    N=document.getElementById("tenure").value;
    R=(r/100)/12;
    
    EMI = P*R*(Math.pow((1+R),N)/(Math.pow((1+R),N)-1));
    EMI=EMI.toFixed(2);
    document.getElementById("result").innerHTML="EMI is Rs."+EMI;
    return false;
}

