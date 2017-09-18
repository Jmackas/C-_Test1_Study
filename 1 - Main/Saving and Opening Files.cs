/*******************************
Remember, requires 'using System.IO;' at the top!
********************************/
/*******************************
Opening a file
********************************/
StreamWriter outputFile;
                // Catch incorrect data entry 
                if (qty <= 0)
                        {
                            // Show user message 
                            MessageBox.Show("Invalid Data Entered, please try again");
                            // Clear input in randamount text box
                            randAmountTextbox.Clear();
                            // Restarts program
                            Application.Restart();
                        }


                // User operates save dialog box
                else if (saveRandFileDiag.ShowDialog() == DialogResult.OK)
                {
                    
                    // create a flie
                    outputFile = File.CreateText(saveRandFileDiag.FileName);
                    

                    // Write Loop random numbers
                    while (count <= qty)
                    {
                        


                        // Add items to listbox
                        outputFile.WriteLine(rand.Next(100 + 1) );


                        // Add to Loop
                        count = count + 1;
                                                
                    }
                    //Close file once saved
                    outputFile.Close();
                }
                else
                {
                    // Message to show save to file cancel 
                    MessageBox.Show(" The operation was cancelled ");
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