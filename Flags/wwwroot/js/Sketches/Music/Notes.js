var createNoteId = 1;

class Note {
  constructor(pitch, names, tier, strings) {
    this.pitch = pitch;
    this.names = names;
    this.tier = tier;
    this.strings = strings;    
    this.id = createNoteId++;
  }
}

var noteNames = {
  "G": "Sol",
  "G#": "Sol#",
  "A♭": "La♭",
  "A": "La",
  "A#": "La#",
  "B♭": "Si♭",
  "B": "Si",
  "C": "Do",
  "C#": "Do#",
  "D♭": "Re♭",
  "D": "Re",
  "D#": "Re#",
  "E♭": "Mi♭",
  "E": "Mi",
  "F": "Fa",
  "F#": "Fa#",
  "G♭": "Sol♭"
}

var notes = [];

notes.push(new Note(196.998, ["G"], 3, ["G"]));
notes.push(new Note(207.652, ["G#", "A♭"], 3, ["G"]));
notes.push(new Note(220.000, ["A"], 3, ["G"]));
notes.push(new Note(233.082, ["A#", "B♭"], 3, ["G"]));
notes.push(new Note(246.942, ["B"], 3, ["G"]));
notes.push(new Note(261.626, ["C"], 4, ["G"]));
notes.push(new Note(277.183, ["C#", "D♭"], 4, ["G"]));
notes.push(new Note(293.665, ["D"], 4, ["G", "D"], ["G", "D"]));
notes.push(new Note(311.127, ["D#", "E♭"], 4, ["G", "D"]));
notes.push(new Note(329.628, ["E"], 4, ["G", "D"]));
notes.push(new Note(349.228, ["F"], 4, ["G", "D"]));
notes.push(new Note(369.994, ["F#", "G♭"], 4, ["G", "D"]));

notes.push(new Note(391.995, ["G"], 4, ["G", "D"]));
notes.push(new Note(415.305, ["G#", "A♭"], 4, ["G", "D"]));
notes.push(new Note(440.000, ["A"], 4, ["D", "A"]));
notes.push(new Note(466.164, ["A#", "B♭"], 4, ["D", "A"]));
notes.push(new Note(493.883, ["B"], 4, ["D", "A"]));
notes.push(new Note(523.251, ["C"], 5, ["D", "A"]));
notes.push(new Note(554.365, ["C#", "D♭"], 5, ["D", "A"]));
notes.push(new Note(587.330, ["D"], 5, ["D", "A"]));
notes.push(new Note(622.254, ["D#", "E♭"], 5, ["D", "A"]));
notes.push(new Note(659.255, ["E"], 5, ["A", "E"]));
notes.push(new Note(698.456, ["F"], 5, ["A", "E"]));
notes.push(new Note(739.989, ["F#", "G♭"], 5, ["A", "E"]));

notes.push(new Note(783.991, ["G"], 5, ["A", "E"]));
notes.push(new Note(830.609, ["G#", "A♭"], 5, ["A", "E"]));
notes.push(new Note(880.000, ["A"], 5, ["A", "E"]));
notes.push(new Note(932.328, ["A#", "B♭"], 5, ["A", "E"]));
notes.push(new Note(987.767, ["B"], 5, ["E"]));
notes.push(new Note(1046.502, ["C"], 6, ["E"]));
notes.push(new Note(1108.731, ["C#", "D♭"], 6, ["E"]));
notes.push(new Note(1174.659, ["D"], 6, ["E"]));
notes.push(new Note(1244.508, ["D#", "E♭"], 6, ["E"]));
notes.push(new Note(1318.510, ["E"], 6, ["E"]));