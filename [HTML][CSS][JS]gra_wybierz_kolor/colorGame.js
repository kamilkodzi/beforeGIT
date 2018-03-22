var colors=generateRandomColors(6);

var squares = document.querySelectorAll(".square");
var pickedColor=pickColor();
var colorDispaly=document.getElementById("colorDispaly");
var messageDisplay=document.querySelector("#message");
var h1=document.querySelector("h1");
colorDisplay.textContent=pickedColor;


for(var i=0;i<squares.length;i++){
	//add initial colors
	squares[i].style.backgroundColor=colors[i];
	//add click listiners to squares
	squares[i].addEventListener("click",function(){
	//grab color of clicked square
		var clickedColor = this.style.backgroundColor;

		console.log(clickedColor);
		console.log(pickedColor);
	//compare color to picked clour
	if(clickedColor===pickedColor){
		messageDisplay.textContent="Correct!";
		changeColors(clickedColor);
		h1.style.backgroundColor=clickedColor;
	} else {
		this.style.backgroundColor="#232323";
		messageDisplay.textContent="Try Again";
	}
	});
}

function changeColors(color){
//loop throug
for (var i=0; i<squares.length;i++){
	squares[i].style.backgroundColor=color;
}}

function pickColor(){
	var random=Math.floor(Math.random() * colors.length);
	return colors[random]
}

function generateRandomColors(num){
	//make array
	var arr=[];
	//add num random colors
	for (var i=0;i<num;i++){
		arr.push(randomColor());
		//get random color and puss to arr

	}
	//return num
	return arr;
}

function randomColor(){
	//pick a red 0-255
	var r=Math.floor(Math.random()*256)
	//pick a red 0-255
	var g=Math.floor(Math.random()*256)
	//pick a red 0-255
	var b=Math.floor(Math.random()*256)

	return "rgb("+r+", "+g+", "+b+")";
}