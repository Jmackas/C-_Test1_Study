  StreamWriter outputFile;

                // Output file creation 
                outputFile = File.CreateText("Numbers.Text");


                SaveFileDialog saveFileControl = new SaveFileDialog();

                // Forcing the user to output the file type '.txt'
                saveFileControl.Filter = "Text Files | *.txt";

                // If statement that opens the save dialog
                if (saveFileControl.ShowDialog() == DialogResult.OK)
                {
                    // Save dialog to create a new file
                    using (Stream s = File.Open(saveFileControl.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        // Loop that outputs the randomly generated numbers to file
                        while (count <= maxNum)
                        {
                            // The counter variable (declared initially above)
                            count++;
                            // Output of the randomly generated + line space
                            sw.Write(rand.Next(100) + Environment.NewLine);
                        }

                    }
                }

                // Exit of the saving 
                outputFile.Close();
            }
