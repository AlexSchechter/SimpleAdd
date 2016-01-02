function SimpleAdd (){
	var number = document.getElementById("myInput").value;
	var result = 0;
	for (i=1; i<=number; i++){
		result += i;
	}
	output.innerHTML = result;
}