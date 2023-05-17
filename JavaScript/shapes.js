//Go to https://jsfiddle.net/ and paste the code below.

// TODO: given the two classes below implement a base class called Shape 
// and rewrite the code to make Circle and Square inherit from Shape.
// Use the IIFEs below to implement the new code.

function Circle() {
  this.X = 0;
  this.Y = 0;
  this.Radious = 0;

  this.Draw = function() {
    console.log(`Circle: ${this.X} ${this.Y} ${this.Radious}`);
  };
}

function Square() {
  this.X = 0;
  this.Y = 0;
  this.Length = 0;

  this.Draw = function() {
    console.log(`Square: ${this.X} ${this.Y} ${this.Length}`);
  };
}

var circle = new Circle();
circle.X = 1;
circle.Y = 2;
circle.Radious = 3;
circle.Draw();
// expected output: "Circle: 1 2 3"
var square = new Square();
square.X = 4;
square.Y = 5;
square.Length = 6;
square.Draw();
// expected output: "Circle: 4 5 6"

var Shape = (function () {
	function Shape(){
  	this.X = 0;
    this.Y = 0;
  }
  Shape.prototype.GetThirdValue = function(){};
  Shape.prototype.GetName = function(){};
  Shape.prototype.Draw = function(){
  	console.log(`${this.GetName()}: ${this.X} ${this.Y} ${this.GetThirdValue()}`);
  };
  return Shape;
}());

var NewCircle = (function () {
	// TODO: inherit from Shape and implement the needed members
  function NewCircle(){
  }
  return NewCircle;
}());

var NewSquare = (function () {
	// TODO: inherit from Shape and implement the needed members
  function NewSquare(){
  }
  return NewSquare;
}());

var newCircle = new NewCircle();
newCircle.X = 7;
newCircle.Y = 8;
newCircle.Radious = 9;
newCircle.Draw();
// expected output: "Circle: 7 8 9"
var newSquare = new NewSquare();
newSquare.X = 10;
newSquare.Y = 11;
newSquare.Length = 12;
newSquare.Draw();
// expected output: "Square: 10 11 12"