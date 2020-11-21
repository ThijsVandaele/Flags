var firstLineY,
  secondLineY,
  thirdLineY,
  FourthLineY,
  FifthLineY;
var spaceBetweenLines = 20;
var noteHeight = spaceBetweenLines;
var scaleLength = 200;
var startScaleX = 100;
var endOfScaleX = startScaleX + scaleLength;

function setup() {
  createCanvas(720, 400);
  background(255);

  firstLineY = 300;
  secondLineY = firstLineY - spaceBetweenLines;
  thirdLineY = secondLineY - spaceBetweenLines;
  FourthLineY = thirdLineY - spaceBetweenLines;
  FifthLineY = FourthLineY - spaceBetweenLines;
}

function draw() {
  drawNote();
  drawScale();
}

function drawScale() {
  strokeWeight(1);
  line(startScaleX, firstLineY, startScaleX + scaleLength, firstLineY);
  line(startScaleX, secondLineY, startScaleX + scaleLength, secondLineY);
  line(startScaleX, thirdLineY, startScaleX + scaleLength, thirdLineY);
  line(startScaleX, FourthLineY, startScaleX + scaleLength, FourthLineY);
  line(startScaleX, FifthLineY, startScaleX + scaleLength, FifthLineY);

  strokeWeight(3);
  line(endOfScaleX, firstLineY - 1, endOfScaleX, FifthLineY + 1);

  strokeWeight(2);
  line(endOfScaleX - 5, firstLineY, endOfScaleX - 5, FifthLineY);
}

function drawNote(){
  var nX = startScaleX + (scaleLength / 2 );
  var nY = thirdLineY - (spaceBetweenLines / 2);

  strokeWeight(3);
  ellipse(nX, nY, noteHeight * 1.2, noteHeight * .9);
  
}