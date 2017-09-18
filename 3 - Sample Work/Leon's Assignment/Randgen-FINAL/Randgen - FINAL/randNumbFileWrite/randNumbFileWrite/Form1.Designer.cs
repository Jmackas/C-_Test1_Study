namespace randNumbFileWrite
{
    partial class randomNumberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.randNumbLabel = new System.Windows.Forms.Label();
            this.randAmountTextbox = new System.Windows.Forms.RichTextBox();
            this.saveRandFileDiag = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(486, 124);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 65);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(363, 124);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 65);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(44, 124);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(235, 65);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Generate and Save to File";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // randNumbLabel
            // 
            this.randNumbLabel.AutoSize = true;
            this.randNumbLabel.Location = new System.Drawing.Point(44, 53);
            this.randNumbLabel.Name = "randNumbLabel";
            this.randNumbLabel.Size = new System.Drawing.Size(205, 20);
            this.randNumbLabel.TabIndex = 4;
            this.randNumbLabel.Text = "Quanity of random numbers";
            // 
            // randAmountTextbox
            // 
            this.randAmountTextbox.Location = new System.Drawing.Point(267, 48);
            this.randAmountTextbox.Name = "randAmountTextbox";
            this.randAmountTextbox.Size = new System.Drawing.Size(336, 31);
            this.randAmountTextbox.TabIndex = 0;
            this.randAmountTextbox.Text = "";
            // 
            // randomNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 222);
            this.Controls.Add(this.randAmountTextbox);
            this.Controls.Add(this.randNumbLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "randomNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label randNumbLabel;
        private System.Windows.Forms.RichTextBox randAmountTextbox;
        private System.Windows.Forms.SaveFileDialog saveRandFileDiag;
    }
}

