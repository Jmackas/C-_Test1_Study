/****************************************
Parsing string to data type
****************************************/
paintArea = decimal.Parse(inputPaintArea.Text);

/****************************************
Outputting label contents
****************************************/
// Outputing 
outputPaintCost.Text = paintCost.ToString();

// Outputing as a number
outputPaintCost.Text = paintCost.ToString("c");

/****************************************
Closing form button
****************************************/
this.Close();