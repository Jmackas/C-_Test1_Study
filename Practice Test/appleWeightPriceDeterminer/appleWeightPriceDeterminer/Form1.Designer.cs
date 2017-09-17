namespace appleWeightPriceDeterminer
{
    partial class AppleQualityDeterminer
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
            this.WeightInputText = new System.Windows.Forms.TextBox();
            this.ClearInputLabelButton = new System.Windows.Forms.Button();
            this.BRadio = new System.Windows.Forms.RadioButton();
            this.CRadio = new System.Windows.Forms.RadioButton();
            this.Aradio = new System.Windows.Forms.RadioButton();
            this.AppleGradesText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeightInputText
            // 
            this.WeightInputText.Location = new System.Drawing.Point(12, 12);
            this.WeightInputText.Name = "WeightInputText";
            this.WeightInputText.Size = new System.Drawing.Size(208, 20);
            this.WeightInputText.TabIndex = 0;
            // 
            // ClearInputLabelButton
            // 
            this.ClearInputLabelButton.Location = new System.Drawing.Point(226, 9);
            this.ClearInputLabelButton.Name = "ClearInputLabelButton";
            this.ClearInputLabelButton.Size = new System.Drawing.Size(75, 23);
            this.ClearInputLabelButton.TabIndex = 1;
            this.ClearInputLabelButton.Text = "Clear";
            this.ClearInputLabelButton.UseVisualStyleBackColor = true;
            // 
            // BRadio
            // 
            this.BRadio.AutoSize = true;
            this.BRadio.Location = new System.Drawing.Point(12, 110);
            this.BRadio.Name = "BRadio";
            this.BRadio.Size = new System.Drawing.Size(32, 17);
            this.BRadio.TabIndex = 2;
            this.BRadio.TabStop = true;
            this.BRadio.Text = "B";
            this.BRadio.UseVisualStyleBackColor = true;
            // 
            // CRadio
            // 
            this.CRadio.AutoSize = true;
            this.CRadio.Location = new System.Drawing.Point(12, 133);
            this.CRadio.Name = "CRadio";
            this.CRadio.Size = new System.Drawing.Size(32, 17);
            this.CRadio.TabIndex = 3;
            this.CRadio.TabStop = true;
            this.CRadio.Text = "C";
            this.CRadio.UseVisualStyleBackColor = true;
            // 
            // Aradio
            // 
            this.Aradio.AutoSize = true;
            this.Aradio.Location = new System.Drawing.Point(12, 87);
            this.Aradio.Name = "Aradio";
            this.Aradio.Size = new System.Drawing.Size(32, 17);
            this.Aradio.TabIndex = 4;
            this.Aradio.TabStop = true;
            this.Aradio.Text = "A";
            this.Aradio.UseVisualStyleBackColor = true;
            // 
            // AppleGradesText
            // 
            this.AppleGradesText.AutoSize = true;
            this.AppleGradesText.Location = new System.Drawing.Point(9, 62);
            this.AppleGradesText.Name = "AppleGradesText";
            this.AppleGradesText.Size = new System.Drawing.Size(71, 13);
            this.AppleGradesText.TabIndex = 5;
            this.AppleGradesText.Text = "Apple Grades";
            // 
            // AppleQualityDeterminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 305);
            this.Controls.Add(this.AppleGradesText);
            this.Controls.Add(this.Aradio);
            this.Controls.Add(this.CRadio);
            this.Controls.Add(this.BRadio);
            this.Controls.Add(this.ClearInputLabelButton);
            this.Controls.Add(this.WeightInputText);
            this.Name = "AppleQualityDeterminer";
            this.Text = "Apple Quality Determiner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeightInputText;
        private System.Windows.Forms.Button ClearInputLabelButton;
        private System.Windows.Forms.RadioButton BRadio;
        private System.Windows.Forms.RadioButton CRadio;
        private System.Windows.Forms.RadioButton Aradio;
        private System.Windows.Forms.Label AppleGradesText;
    }
}

