/****************************************
Parsing string to data type
****************************************/
paintArea = decimal.Parse(inputPaintArea.Text);

/****************************************
Outputting label contents
****************************************/
// Outputing as a number
outputPaintCost.Text = paintCost.ToString();

// Outputting with restricted amount of decimal places (2 in this instance)
outputPaintCost.Text = paintCost.ToString("0.##");

// Outputing as a price
outputPaintCost.Text = paintCost.ToString("c");

/****************************************
Closing form button
****************************************/
this.Close();