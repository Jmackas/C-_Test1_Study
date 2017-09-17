﻿namespace appleWeightPriceDeterminer
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
            this.weightInputText = new System.Windows.Forms.TextBox();
            this.clearInputLabelButton = new System.Windows.Forms.Button();
            this.bRadio = new System.Windows.Forms.RadioButton();
            this.cRadio = new System.Windows.Forms.RadioButton();
            this.aRadio = new System.Windows.Forms.RadioButton();
            this.AppleGradesText = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitFormButton = new System.Windows.Forms.Button();
            this.finalOutputPrice = new System.Windows.Forms.Label();
            this.instructionEnterAppleWeight = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // weightInputText
            // 
            this.weightInputText.Location = new System.Drawing.Point(6, 28);
            this.weightInputText.Name = "weightInputText";
            this.weightInputText.Size = new System.Drawing.Size(93, 20);
            this.weightInputText.TabIndex = 0;
            // 
            // clearInputLabelButton
            // 
            this.clearInputLabelButton.Location = new System.Drawing.Point(105, 25);
            this.clearInputLabelButton.Name = "clearInputLabelButton";
            this.clearInputLabelButton.Size = new System.Drawing.Size(75, 23);
            this.clearInputLabelButton.TabIndex = 1;
            this.clearInputLabelButton.Text = "Clear";
            this.clearInputLabelButton.UseVisualStyleBackColor = true;
            // 
            // bRadio
            // 
            this.bRadio.AutoSize = true;
            this.bRadio.Location = new System.Drawing.Point(15, 104);
            this.bRadio.Name = "bRadio";
            this.bRadio.Size = new System.Drawing.Size(32, 17);
            this.bRadio.TabIndex = 2;
            this.bRadio.TabStop = true;
            this.bRadio.Text = "B";
            this.bRadio.UseVisualStyleBackColor = true;
            // 
            // cRadio
            // 
            this.cRadio.AutoSize = true;
            this.cRadio.Location = new System.Drawing.Point(15, 127);
            this.cRadio.Name = "cRadio";
            this.cRadio.Size = new System.Drawing.Size(32, 17);
            this.cRadio.TabIndex = 3;
            this.cRadio.TabStop = true;
            this.cRadio.Text = "C";
            this.cRadio.UseVisualStyleBackColor = true;
            // 
            // aRadio
            // 
            this.aRadio.AutoSize = true;
            this.aRadio.Location = new System.Drawing.Point(15, 81);
            this.aRadio.Name = "aRadio";
            this.aRadio.Size = new System.Drawing.Size(32, 17);
            this.aRadio.TabIndex = 4;
            this.aRadio.TabStop = true;
            this.aRadio.Text = "A";
            this.aRadio.UseVisualStyleBackColor = true;
            // 
            // AppleGradesText
            // 
            this.AppleGradesText.AutoSize = true;
            this.AppleGradesText.Location = new System.Drawing.Point(12, 65);
            this.AppleGradesText.Name = "AppleGradesText";
            this.AppleGradesText.Size = new System.Drawing.Size(71, 13);
            this.AppleGradesText.TabIndex = 5;
            this.AppleGradesText.Text = "Apple Grades";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(6, 248);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(127, 45);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitFormButton
            // 
            this.exitFormButton.Location = new System.Drawing.Point(174, 248);
            this.exitFormButton.Name = "exitFormButton";
            this.exitFormButton.Size = new System.Drawing.Size(127, 45);
            this.exitFormButton.TabIndex = 7;
            this.exitFormButton.Text = "Exit";
            this.exitFormButton.UseVisualStyleBackColor = true;
            // 
            // finalOutputPrice
            // 
            this.finalOutputPrice.AutoSize = true;
            this.finalOutputPrice.Location = new System.Drawing.Point(124, 178);
            this.finalOutputPrice.Name = "finalOutputPrice";
            this.finalOutputPrice.Size = new System.Drawing.Size(56, 13);
            this.finalOutputPrice.TabIndex = 8;
            this.finalOutputPrice.Text = "Final Price";
            // 
            // instructionEnterAppleWeight
            // 
            this.instructionEnterAppleWeight.AutoSize = true;
            this.instructionEnterAppleWeight.Location = new System.Drawing.Point(3, 9);
            this.instructionEnterAppleWeight.Name = "instructionEnterAppleWeight";
            this.instructionEnterAppleWeight.Size = new System.Drawing.Size(163, 13);
            this.instructionEnterAppleWeight.TabIndex = 9;
            this.instructionEnterAppleWeight.Text = "Enter Apple/s Weight (Kilograms)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // AppleQualityDeterminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 305);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.instructionEnterAppleWeight);
            this.Controls.Add(this.finalOutputPrice);
            this.Controls.Add(this.exitFormButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.AppleGradesText);
            this.Controls.Add(this.aRadio);
            this.Controls.Add(this.cRadio);
            this.Controls.Add(this.bRadio);
            this.Controls.Add(this.clearInputLabelButton);
            this.Controls.Add(this.weightInputText);
            this.Name = "AppleQualityDeterminer";
            this.Text = "Apple Quality Determiner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weightInputText;
        private System.Windows.Forms.Button clearInputLabelButton;
        private System.Windows.Forms.RadioButton bRadio;
        private System.Windows.Forms.RadioButton cRadio;
        private System.Windows.Forms.RadioButton aRadio;
        private System.Windows.Forms.Label AppleGradesText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitFormButton;
        private System.Windows.Forms.Label finalOutputPrice;
        private System.Windows.Forms.Label instructionEnterAppleWeight;
        private System.Windows.Forms.TextBox textBox1;
    }
}

