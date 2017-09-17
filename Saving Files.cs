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
        
    }

   }
  }

  // Exit of the saving 
  outputFile.Close();
  }
