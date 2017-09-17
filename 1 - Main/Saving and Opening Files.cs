/*******************************
Remember, requires 'using System.IO;' at the top!
********************************/
/*******************************
Opening a file
********************************/
// Restrict file name type in save dialog
openRandFileDiag.Filter = "Text Files | *.txt";

// Set file default name to text type in dialog
openRandFileDiag.DefaultExt = "txt";

// Declare open file
OpenFileDialog open = new OpenFileDialog();

// Detect user selection
if (openRandFileDiag.ShowDialog() == DialogResult.OK) {

 // Open the file and get a streamreader object * make sure the target name is the open dialog
 inputFile = (File.OpenText(openRandFileDiag.FileName));

 // Clear anything in list box
 randBox.Items.Clear();


 // Read the contents
 while (!inputFile.EndOfStream) {
  //Get random number
  randomNumber = inputFile.ReadLine();
  // Add random number to listbox
  randBox.Items.Add(randomNumber);
 }

 //close
 inputFile.Close();

}


/*******************************
Saving a file
********************************/
StreamWriter outputFile;

// Output file creation 
outputFile = File.CreateText("Numbers.Text");

SaveFileDialog saveFileControl = new SaveFileDialog();

// Forcing the user to output the file type '.txt'
saveFileControl.Filter = "Text Files | *.txt";

// If statement that opens the save dialog
if (saveFileControl.ShowDialog() == DialogResult.OK) {

 // Save dialog to create a new file
 using(Stream s = File.Open(saveFileControl.FileName, FileMode.CreateNew))
 using(StreamWriter sw = new StreamWriter(s)) {
  // Loop that outputs the randomly generated numbers to file
  while (count <= maxNum) {
   // The counter variable (declared initially above)
   count++;
   // Output of the randomly generated + line space
   sw.Write(rand.Next(100) + Environment.NewLine);
  }
 }

}
}

// Exit of the saving 
outputFile.Close();
}