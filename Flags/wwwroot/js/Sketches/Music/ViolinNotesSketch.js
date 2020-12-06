var GstringX,
  DstringX,
  AstringX,
  EstringX;

var GstringNotes = [];
var DstringNotes = [];
var AstringNotes = [];
var EstringNotes = [];

function setup()
{
  createCanvas(720, 400);
  background(255);

  // Fill String Notes
  GstringNotes = notes.filter(note => note.strings.includes("G"));

  console.log(GstringNotes);
}

function draw()
{

}

function drawFingerBoard() {
  drawGstring();
}

function drawGstring() {

}

